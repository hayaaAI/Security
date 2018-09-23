package hayaa.workersecurity.client;

import hayaa.cachekeystatic.JobAuthorityCacheKey;
import hayaa.cachekeystatic.UserAuthorityCacheKey;
import hayaa.redis.client.RedisService;

import java.util.Date;

class WorkerSecurityProvider {
    public static Boolean UserAuth(String token)
    {
        Boolean result = false;
        LoginToken info = RedisService.get(DefineTable.cacheName, UserAuthorityCacheKey.AuthorityCacheKey.replace("{0}",token));
        if (info != null)
        {
            if ((info.getStatus()) && (info.getEndTime().getTime() > (new Date()).getTime()))
            {
                result = true;
            }

        }
        return result;
    }
    public static Boolean WorkerAuth(String token)
    {
        Boolean result = false;
        JobToken info = RedisService.get(DefineTable.cacheName,JobAuthorityCacheKey.AuthorityCacheKey.replace("{0}",token));
        if (info != null)
        {
            if(info.getEndTime().getTime() > (new Date()).getTime())
            {
                result = true;
            }

        }
        return result;
    }
}
