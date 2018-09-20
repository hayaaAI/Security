package hayaa.scan.site;

import hayaa.basemodel.model.BaseData;

public class AppFunction extends BaseData {
    private Integer appFuntionId;

    public Integer getAppFuntionId() {
        return appFuntionId;
    }

    public void setAppFuntionId(Integer appFuntionId) {
        this.appFuntionId = appFuntionId;
    }

    public String getFunctionName() {
        return functionName;
    }

    public void setFunctionName(String functionName) {
        this.functionName = functionName;
    }

    public String getPathName() {
        return pathName;
    }

    public void setPathName(String pathName) {
        this.pathName = pathName;
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

    public Integer getAppServiceId() {
        return appServiceId;
    }

    public void setAppServiceId(Integer appServiceId) {
        this.appServiceId = appServiceId;
    }

    private String functionName;
    private String pathName;
    private String title;
    private byte status;
    private Integer appServiceId;
}
