package hayaa.workersecurity.client;

import java.util.Date;

class JobToken {
    private Integer jobTokenId;
    private Integer jobId;
    private Integer userId;
    private String token;
    private Date endTime;

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



}
