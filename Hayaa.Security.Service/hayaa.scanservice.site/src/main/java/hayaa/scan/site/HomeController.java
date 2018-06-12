package hayaa.scan.site;

import hayaa.basemodel.model.ServiceDescDocment;
import hayaa.common.DateTimeHelper;
import org.apache.tomcat.jni.Directory;
import org.springframework.boot.autoconfigure.EnableAutoConfiguration;
import org.springframework.util.StringUtils;
import org.springframework.web.bind.annotation.*;
import org.springframework.web.multipart.MultipartFile;
import org.springframework.web.servlet.mvc.support.RedirectAttributes;
import org.zeroturnaround.zip.ZipUtil;

import java.io.*;
import java.lang.reflect.Method;
import java.net.MalformedURLException;
import java.net.URL;
import java.net.URLClassLoader;
import java.util.ArrayList;
import java.util.Enumeration;
import java.util.List;
import java.util.Properties;
import java.util.jar.JarEntry;
import java.util.jar.JarFile;
import java.util.zip.ZipEntry;
import java.util.zip.ZipFile;

@RestController
@EnableAutoConfiguration
@RequestMapping(value = "/home/", method = {RequestMethod.GET, RequestMethod.POST})
@CrossOrigin(origins = "*", allowCredentials = "true")
public class HomeController {
    @RequestMapping(value = "index")
    public String index() {
        return "home";
    }

    @RequestMapping(value = "uploaddll")
    public List<AppService> uploadDll(@RequestParam("file") MultipartFile file,
                                      RedirectAttributes redirectAttributes) {
        Properties props = System.getProperties();
        String baseDirectory = props.getProperty("user.dir")+ "/jars/"+DateTimeHelper.getTimeToken()+"/";
        File newDic=new File(baseDirectory);
        newDic.mkdir();
        List<AppService> result = null;
        try {
            File targetFile = new File(baseDirectory);
            result = getAppComponentService(file.getInputStream(), targetFile);
        } catch (IOException e) {
            e.printStackTrace();
        }
        return result;
    }

    private List<AppService> getAppComponentService(InputStream file, File unpackDic) {
        List<AppService> list = new ArrayList<>();
        try {
            ZipUtil.unpack(file, unpackDic);
        } catch (Exception e) {
            e.printStackTrace();
            return list;
        }
        File dic = new File(unpackDic.toString() + "/BOOT-INF/lib");
        JarLoaderUtil.loadJarPath(unpackDic.toString() + "/BOOT-INF/lib");
        File[] fileList = dic.listFiles();
        if (fileList != null) {
            for (int i = 0; i < fileList.length; i++) {
                String name = fileList[i].getName();
                if (!name.contains("controller")) {
                    continue;
                }
                JarFile jarFile = null;
                try {
                    File fileInfo = fileList[i].getAbsoluteFile();
                    jarFile = new JarFile(fileInfo);
                } catch (IOException e) {
                    e.printStackTrace();
                }
                Enumeration<JarEntry> entrys = jarFile.entries();
                while (entrys.hasMoreElements()) {
                    JarEntry jarEntry = entrys.nextElement();
                    if (jarEntry.getName().contains("Controller")) {
                        AppService appService = new AppService();
                        list.add(appService);
                        appService.setAppFunctions(new ArrayList<>());

                        Class<?> myClass = null;
                        try {
                            String className = jarEntry.getName().replace("BOOT-INF/classes/", "");
                            className = className.replace("/", ".").replace(".class", "");
                            myClass = Class.forName(className);
                            String[] arr=  className.split("\\.");
                            appService.setName(arr[arr.length-1]);
                            appService.setTitle(arr[arr.length-1]);
                        } catch (ClassNotFoundException e) {
                            e.printStackTrace();
                        }
                        Method[] methods = myClass.getDeclaredMethods();
                        if (methods != null) {
                            for (int j = 0; j < methods.length; j++) {
                                ServiceDescDocment sd = methods[j].getAnnotation(ServiceDescDocment.class);
                                if (sd != null) {
                                    AppFunction appFunction = new AppFunction();
                                    appService.getAppFunctions().add(appFunction);
                                    appFunction.setTitle(sd.title());
                                    appFunction.setFunctionName(methods[j].getName());
                                    appFunction.setPathName(sd.name().toLowerCase());
                                }
                            }
                        }
                    }
                }
            }
        }
        return list;
    }


}
