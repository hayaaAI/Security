
SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for `AppFuntion`
-- ----------------------------
DROP TABLE IF EXISTS `AppFuntion`;
CREATE TABLE `AppFuntion` (
  `AppFuntionId` int(11) NOT NULL AUTO_INCREMENT,
  `FuntionName` varchar(300) NOT NULL,
  `PathName` varchar(300) DEFAULT '请求路径名，默认与FuntionName相同',
  `Title` varchar(50) DEFAULT '',
  `Status` tinyint(4) NOT NULL DEFAULT 0 COMMENT '功能状态:0关闭1开始2已注销',
  `AppServiceId` int(11) NOT NULL,
  `CreateTime` timestamp NULL DEFAULT current_timestamp(),
  `UpdateTime` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`AppFuntionId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of AppFuntion
-- ----------------------------

-- ----------------------------
-- Table structure for `AppService`
-- ----------------------------
DROP TABLE IF EXISTS `AppService`;
CREATE TABLE `AppService` (
  `AppServiceId` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(300) NOT NULL,
  `Title` varchar(300) DEFAULT NULL,
  `AppId` int(11) NOT NULL,
  `CreateTime` timestamp NULL DEFAULT current_timestamp(),
  `UpdateTime` timestamp NULL DEFAULT current_timestamp() ON UPDATE current_timestamp(),
  PRIMARY KEY (`AppServiceId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of AppService
-- ----------------------------

-- ----------------------------
-- Table structure for `Rel_App_AppFunction`
-- ----------------------------
DROP TABLE IF EXISTS `Rel_App_AppFunction`;
CREATE TABLE `Rel_App_AppFunction` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `AppId` int(11) NOT NULL,
  `AppFunctionId` int(11) NOT NULL,
  `CreateTime` timestamp NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='App授权可访问功能数据';

-- ----------------------------
-- Records of Rel_App_AppFunction
-- ----------------------------

-- ----------------------------
-- Table structure for `Rel_Job_AppFunction`
-- ----------------------------
DROP TABLE IF EXISTS `Rel_Job_AppFunction`;
CREATE TABLE `Rel_Job_AppFunction` (
  `Id` int(11) NOT NULL AUTO_INCREMENT,
  `JobId` int(11) NOT NULL,
  `AppFunctionId` int(11) NOT NULL,
  `CreateTime` timestamp NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='岗位对应服务功能';

-- ----------------------------
-- Records of Rel_Job_AppFunction
-- ----------------------------
