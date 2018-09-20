package hayaa.scan.site;

import java.util.List;

public class AppService {
    private Integer appServiceId;
    private Integer appId;
    private String name;

    public Integer getAppServiceId() {
        return appServiceId;
    }

    public void setAppServiceId(Integer appServiceId) {
        this.appServiceId = appServiceId;
    }

    public Integer getAppId() {
        return appId;
    }

    public void setAppId(Integer appId) {
        this.appId = appId;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public byte getStatus() {
        return status;
    }

    public void setStatus(byte status) {
        this.status = status;
    }

    public List<AppFunction> getAppFunctions() {
        return appFunctions;
    }

    public void setAppFunctions(List<AppFunction> appFunctions) {
        this.appFunctions = appFunctions;
    }

    private String title;
    private byte status;
    private List<AppFunction> appFunctions;
}
