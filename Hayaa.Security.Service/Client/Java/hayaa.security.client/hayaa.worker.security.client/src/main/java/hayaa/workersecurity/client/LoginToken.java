package hayaa.workersecurity.client;

import java.util.Date;

class LoginToken {
    public Integer getJobTokenId() {
        return jobTokenId;
    }

    public void setJobTokenId(Integer jobTokenId) {
        this.jobTokenId = jobTokenId;
    }

    public Integer getJobId() {
        return jobId;
    }

    public void setJobId(Integer jobId) {
        this.jobId = jobId;
    }

    public Integer getUserId() {
        return userId;
    }

    public void setUserId(Integer userId) {
        this.userId = userId;
    }

    public String getToken() {
        return token;
    }

    public void setToken(String token) {
        this.token = token;
    }

    public Date getEndTime() {
        return endTime;
    }

    public void setEndTime(Date endTime) {
        this.endTime = endTime;
    }

    public Boolean getStatus() {
        return status;
    }

    public void setStatus(Boolean status) {
        this.status = status;
    }

    private Integer jobTokenId;
    private Integer jobId;
    private Integer userId;
    private String token;
    private Date endTime;
    private Boolean status;
}
