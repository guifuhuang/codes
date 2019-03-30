using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DcCommon.Helper
{
    public class Consts
    {
        // 应用服务器ID
        public const string CONFIG_NAME_APP_SERVER_IP = "APP_SERVER_IP";
        // 默认目录
        public const string CONFIG_NAME_DEFAULT_PATH = "DEFAULT_PATH";

        #region 客户端权限相关
        // 报检单查询
        public const string STRING_POWER_NAME_InspectionManagerForm = "InspectionManagerForm";
        // 检测数据查询
        public const string STRING_POWER_NAME_MachineDataManagerForm = "MachineDataManagerForm";
        // 校准数据查询
        public const string STRING_POWER_NAME_CheckDataManagerForm = "CheckDataManagerForm";
        // 暂存数据查询
        public const string STRING_POWER_NAME_ImportLocalDataDialog = "ImportLocalDataDialog";

        // 设备主数据管理
        public const string STRING_POWER_NAME_MachineManagerForm = "MachineManagerForm";
        // PDM指标主数据管理
        public const string STRING_POWER_NAME_PdmInspectionItemManagerForm = "PdmInspectionItemManagerForm";
        // 仪器数采指标主数据管理
        public const string STRING_POWER_NAME_InspectionItemManagerForm = "InspectionItemManagerForm";

        // 接口日志管理
        public const string STRING_POWER_NAME_ServiceLogManagerForm = "ServiceLogManagerForm";
        // 用户权限管理
        public const string STRING_POWER_NAME_UserPowerManagerForm = "UserPowerManagerForm";
        // 有效值管理
        public const string STRING_POWER_NAME_ValidValueManagerForm = "ValidValueManagerForm";
        // 校准值标准管理
        public const string STRING_POWER_NAME_ValidValueForCheckManagerForm = "ValidValueForCheckManagerForm";
        // 报检单过滤管理
        public const string STRING_POWER_NAME_FilterSettingManagerForm = "FilterSettingManagerForm";
        // 系统参数管理
        public const string STRING_POWER_NAME_DdivManagerForm = "DdivManagerForm";


        // 系统日志
        public const string STRING_POWER_NAME_LogViewForm = "LogViewForm";
        // 系统升级
        public const string STRING_POWER_NAME_UpdateForm = "UpdateForm";
        // 关于
        public const string STRING_POWER_NAME_AboutForm = "AboutForm";
        
        #endregion

        #region A17傅立叶光谱仪相关

        // 默认目录【光谱文件】
        public const string CONFIG_NAME_SPECTRA_PATH = "SPECTRA_PATH";
        // 默认目录【100%直线】
        public const string CONFIG_NAME_STRAIGHTLINE_PATH = "STRAIGHTLINE_PATH";
        // 默认目录【背景】
        public const string CONFIG_NAME_BACKGROUND_PATH = "BACKGROUND_PATH";
        // 默认目录【单光束】
        public const string CONFIG_NAME_SINGLEBEAM_PATH = "SINGLEBEAM_PATH";
        // 默认目录【仪器状态值】
        public const string CONFIG_NAME_ANTARISSTATUSFILE_PATH = "ANTARISSTATUSFILE_PATH";
        // 默认目录【傅立叶光谱仪模型函数库】
        public const string CONFIG_NAME_LIBRARY_PATH = "LIBRARY_PATH";
        // MataLab类名称
        public const string MATLAB_CLS_NAME_NATIVE = "AntarisLibNative.AnalysisModel";
        public const string CONFIG_NAME_MATLAB_CLS_NAME_NATIVE = "MATLAB_CLS_NAME_NATIVE";
        // MataLab函数名称(测试)
        public const string MATLAB_FUN_NAME_TEST = "test";
        // MataLab函数名称(部位)
        public const string MATLAB_FUN_NAME_POSITION = "AnalysePosition";
        // MataLab函数名称(感官)
        public const string MATLAB_FUN_NAME_FEEL = "AnalyseFeel";
        // MataLab函数名称(化学值)
        public const string MATLAB_FUN_NAME_CHEMISTRY = "AnalyseChemistry";
        // MataLab函数名称(香型)
        public const string MATLAB_FUN_NAME_ODOR = "AnalyseOdor";
        // MataLab函数名称(背景)
        public const string MATLAB_FUN_NAME_BACKGROUND = "AnalyseBackground";
        // MataLab函数名称(外点)
        public const string MATLAB_FUN_NAME_OUTPOINT = "AnalyseOutPoint";
        #endregion

        #region A12色差仪相关

        // DE1描述健
        public const string STRING_A12_DE_SE03C019 = "SE03C019";
        // DE2描述健
        public const string STRING_A12_DE_SE03C020 = "SE03C020";

        #endregion

        // 默认设备
        public const string CONFIG_NAME_DEFAULT_MACHINE = "DefaultMachine";
        // 升级路径
        public const string CONFIG_NAME_UPDATE_URL = "UPDATE_URL";
        // 每页显示条数
        public const string CONFIG_NAME_PAGE_SIZE = "PAGE_SIZE";
        // 信息中心部门编码
        public const string CONFIG_NAME_INFO_DEPT_CODE = "INFO_DEPT_CODE";
        // 信息中心部门编码
        public const string STRING_DEPT_CD_INFOMATION = "10000058";
        // 技术中心部门编码
        public const string CONFIG_NAME_TECH_DEPT_CODE = "TECH_DEPT_CODE";
        // 技术中心部门编码
        public const string STRING_DEPT_CD_TECHNOLOGY = "10000048";
        // 是否显示数据LOG窗口
        public const string CONFIG_NAME_SHOW_LOG_DIALOG = "SHOW_LOG_DIALOG";
        // 是否显示批量导入有效值验证数据按钮
        public const string CONFIG_NAME_SHOW_IMPORT_DIALOG = "SHOW_IMPORT_DIALOG";
        // 杭州厂
        public const string CONFIG_NAME_FACTORY_CODE_HANGZHOU = "FACTORY_CODE_HANGZHOU";
        // 宁波厂
        public const string CONFIG_NAME_FACTORY_CODE_NINGBO = "FACTORY_CODE_NINGBO";
        // 相同报检单是否删除已检测的数据
        public const string CONFIG_NAME_IF_SAME_ORDERKEY_DELETE_DATA = "IF_SAME_ORDERKEY_DELETE_DATA";

        // 报检单搜索的默认文字
        public const string InspectionSearchTooltipString = "搜索报检单(如：烤烟)";
        // 用户搜索的默认文字
        public const string UserSearchTooltipString = "姓名或员工号";
        // 仪器设备搜索的默认文字
        public const string IOLogSearchTooltipString = "输入条件筛选结果(如：ERP)";
        // PDM指标主数据搜索的默认文字
        public const string PDMInspectionItemSearchTooltipString = "输入条件筛选结果(如：高度)";
        // 仪器数采指标主数据搜索的默认文字
        public const string InspectionItemSearchTooltipString = "输入条件筛选结果(如：高度)";

        // 仪器设备搜索的默认文字
        public const string MachineSearchTooltipString = "输入条件筛选结果(如：拉力机)";

        // 采集数据的统计值表名
        public const string STRING_TABLENAME_SUM = "Sum";
        // 采集数据的单值表名
        public const string STRING_TABLENAME_DETAIL = "Detail";
        // 采集数据的参数表名
        public const string STRING_TABLENAME_PARAMETER = "Parameter";
        // 采集数据的混合值表名
        public const string STRING_TABLENAME_MIX = "Mix";
        // 最后登录的用户
        public const string STRING_KEY_LAST_USERID = "LastUserId";

        #region Antaris傅里叶变换近红外光谱仪

        // Antaris傅里叶变换近红外光谱仪【光谱文件】
        public const string STRING_TABLENAME_SPECTRA = "Spectra";
        // Antaris傅里叶变换近红外光谱仪【100%直线】
        public const string STRING_TABLENAME_STRAIGHTLINE = "StraightLine";
        // Antaris傅里叶变换近红外光谱仪【背景】
        public const string STRING_TABLENAME_BACKGROUND = "Background";
        // Antaris傅里叶变换近红外光谱仪【单光束】
        public const string STRING_TABLENAME_SINGLEBEAM = "SingleBeam"; 

        #endregion

        // 标样的标识字符串
        public const string STRING_VERSION_MARK_TEST = "（测试版本）";
        // 标样的标识字符串
        public const string STRING_STD_MARK = "标";

        // 校准数据采集配置的型号:
        public const string STRING_ADJUST = "ADJUST";
        // 空字符串
        public const string STRING_BLANK_CN = "(空)";
        // 成功标识字符串
        public const string STRING_SUCCESS_CN = "成功";
        // 密码复杂验证
        public const string STRING_REGEXP_PASSWORD = @"(?=.*\d)(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9]).{8,30}";
        //JS:(?=.*[0-9])(?=.*[a-zA-Z])(?=.*[^a-zA-Z0-9]).{8,30}

        #region 配置文件名称

        // 用户可以使用的设备种类配置文件
        public const string STRING_CONFIG_FILENAME_SPECIALSETTING = "Special.Setting";
        // 用户可以使用的设备种类配置文件
        public const string STRING_CONFIG_FILENAME_OPDCTYPE = "OpDcType.cfg";
        // 有效值验证数据配置文件
        public const string STRING_CONFIG_FILENAME_VALIDS = "Valids.BAK";

        // txt.xml配置文件
        public const string STRING_CONFIG_FILENAME_TXT_XML = "txt.xml";
        // csv.xml配置文件
        public const string STRING_CONFIG_FILENAME_CSV_XML = "csv.xml";
        // com.xml配置文件
        public const string STRING_CONFIG_FILENAME_COM_XML = "com.xml";
        // excel.xml配置文件
        public const string STRING_CONFIG_FILENAME_EXCEL_XML = "excel.xml";
        // htm.xml配置文件
        public const string STRING_CONFIG_FILENAME_HTM_XML = "htm.xml";
        // xps.xml配置文件
        public const string STRING_CONFIG_FILENAME_XPS_XML = "xps.xml";
        // Departments.xml配置文件
        public const string STRING_CONFIG_FILENAME_DEPARTMENTS_XML = "Departments.xml";
        // General.xml配置文件
        public const string STRING_CONFIG_FILENAME_GENERAL_XML = "General.xml";
        // Users.xml配置文件
        public const string STRING_CONFIG_FILENAME_USERS_XML = "Users.xml";
        #endregion

        #region 缓存
        public const string CACHE_KEY_MACHINEDATACOLUMN = "CACHE_KEY_MACHINEDATACOLUMN";
        public const string CACHE_KEY_MACHINETYPE_TO_TABLENAME = "CACHE_KEY_MACHINETYPE_TO_TABLENAME";
        public const string CACHE_KEY_UPLOAD_RECORDCOUNT = "CACHE_KEY_UPLOAD_RECORDCOUNT";
        #endregion

        #region 符号

        public const char CHAR_SPACE_FULL = '　';
        public const char CHAR_SPACE_HALF = ' ';
        public const char CHAR_TAB = '	';
        public const char CHAR_COMMA = ',';
        public const char CHAR_SEMICOLON = ';';
        public const char CHAR_BRACKET_LEFT = '[';
        public const char CHAR_BRACKET_RIGHT = ']';

        #endregion

        #region 报检单状态类型
        /// <summary>
        /// 正常
        /// </summary>
        public const int INT_INSPECTION_STATUS_NORMAL = 0;
        /// <summary>
        /// 复检
        /// </summary>
        public const int INT_INSPECTION_STATUS_RECHECK = 1;
        /// <summary>
        /// 红冲
        /// </summary>
        public const int INT_INSPECTION_STATUS_BACK = -1;
        
        #endregion
        
        #region 设备编码
        /// <summary>
        /// 拉力机
        /// </summary>
        public const string Machine_Pulling = "0";
        /// <summary>
        /// 色差仪
        /// </summary>
        public const string Machine_ColoriMeter = "1";
        /// <summary>
        /// 数码成像测量系统
        /// </summary>
        public const string Machine_DigitalImaging = "2";
        /// <summary>
        /// 条码仪
        /// </summary>
        public const string Machine_BarCode = "3";
        /// <summary>
        /// 透气度仪
        /// </summary>
        public const string Machine_AirPermeability = "4";
        /// <summary>
        /// 白度仪
        /// </summary>
        public const string Machine_WhitenessMeter = "5";
        /// <summary>
        /// 折痕挺度仪
        /// </summary>
        public const string Machine_CreaseStiffness = "6";
        /// <summary>
        /// 雾度仪
        /// </summary>
        public const string Machine_Fogmeter = "7";
        /// <summary>
        /// 摩擦系数仪
        /// </summary>
        public const string Machine_FrictionCoefficient = "8";
        /// <summary>
        /// 光泽度仪
        /// </summary>
        public const string Machine_GlossMeter = "9";
        /// <summary>
        /// 扩散率仪
        /// </summary>
        public const string Machine_DiffusionRateMeter = "10";
        /// <summary>
        /// 单丝线密度仪
        /// </summary>
        public const string Machine_SingleThreadDensityMeter = "11";
        /// <summary>
        /// 激光粒度仪
        /// </summary>
        public const string Machine_LaserParticleSizeAnalyzer = "12";
        /// <summary>
        /// 便携式分光密度仪   
        /// </summary>
        public const string Machine_PortableOpticalDensityMeter = "13";
        /// <summary>
        /// 压痕测试仪    
        /// </summary>
        public const string Machine_IndentationTester = "14";
        /// <summary>
        /// 纸张强度测试仪    
        /// </summary>
        public const string Machine_PaperStrengthTester = "15";
        /// <summary>
        /// 纸张粗糙度测试仪   
        /// </summary>
        public const string Machine_PaperRoughnessTester = "16";
        /// <summary>
        /// 转盘吸烟机   
        /// </summary>
        public const string Machine_RotaryTableSmokingMachine = "17";
        /// <summary>
        /// 直线吸烟机   
        /// </summary>
        public const string Machine_LinearSmokingMachine = "18";
        /// <summary>
        /// Antaris傅里叶变换近红外光谱仪   
        /// </summary>
        public const string Machine_AntarisFourierTransformNearInfraredSpectrometer = "19";
        /// <summary>
        /// 长度仪   
        /// </summary>
        public const string Machine_LengthMeasuringInstrument = "20";
        /// <summary>
        /// 数字投影仪   
        /// </summary>
        public const string Machine_DigitalProjector = "21";
        /// <summary>
        /// 转盘吸烟机(RM200)
        /// </summary>
        public const string Machine_RotarySmokingMachine = "22";
        /// <summary>
        /// 密度折光联用仪   
        /// </summary>
        public const string Machine_DensityRefractionSpectrometer = "23";
        /// <summary>
        /// 含末率测定仪   
        /// </summary>
        public const string Machine_DustContentDeterminationApparatus = "24";
        #endregion

        #region 接口相关

        // ERP用户主数据接口
        public const string IF_I_ERP_USER = "I_ERP_USER";
        // ERP部门主数据接口
        public const string IF_I_ERP_DEPARTMENT = "I_ERP_DEPARTMENT";
        // ERP物料主数据接口
        public const string IF_I_ERP_MATERIEL = "I_ERP_MATERIEL";
        // PDM辅料报检单接口
        public const string IF_I_PDM_INSPECTION_M = "I_PDM_INSPECTION_M";
        // PDM日常报检单接口
        public const string IF_I_PDM_INSPECTION_D = "I_PDM_INSPECTION_D";
        // PDM成品报检单接口
        public const string IF_I_PDM_INSPECTION_P = "I_PDM_INSPECTION_P";
        // PDM指标主数据接口
        public const string IF_I_PDM_INSPECT_ITEM = "I_PDM_INSPECT_ITEM";

        // PDM辅料报检单接口(回传)
        public const string IF_O_PDM_INSPECTION_M = "O_PDM_INSPECTION_M";
        // PDM成品报检单接口(回传)
        public const string IF_O_PDM_INSPECTION_P = "O_PDM_INSPECTION_P";
        // PDM日常报检单接口(回传)
        public const string IF_O_PDM_INSPECTION_D = "O_PDM_INSPECTION_D";

        #endregion

        #region 采集数据表公用列名称
        // 设置【单值】表和【统计值表】唯一关联列
        public const string STRING_COLNAME_PUBLIC_KEY = "PUBLIC_KEY";
        // 设置报检单号列
        public const string STRING_COLNAME_ORDER_KEY = "ORDER_KEY";
        // 设置检验环节列
        public const string STRING_COLNAME_DETECTION_LINK_ID = "DETECTION_LINK_ID";
        // 复检标识
        public const string STRING_COLNAME_RECHECK_SN = "RECHECK_SN";
        // 设置样品编号列
        public const string STRING_COLNAME_SAMPLE_NUMBER = "SAMPLE_NUMBER";
        // 设置样品序号列
        public const string STRING_COLNAME_SAMPLE_SN = "SAMPLE_SN";
        // 设置采集人列
        public const string STRING_COLNAME_INSPECTION_PERSON = "INSPECTION_PERSON";
        // 设置数据状态列
        public const string STRING_COLNAME_DATA_STATUS = "DATA_STATUS";
        // 设备编号列
        public const string STRING_COLNAME_EQUNR = "EQUNR";
        // 样品描述列
        public const string STRING_COLNAME_IDENTIFICATION_ID = "IDENTIFICATION_ID";

        // 数据验证列
        public const string STRING_COLNAME_VALIDVALUE = "VALID_VALUE";
        // 标样编码列
        public const string STRING_COLNAME_DIV_STD_CODE = "DIV_STD_CODE";
        // 标样名称列
        public const string STRING_COLNAME_DIV_STD_NAME = "DIV_STD_NAME";


        // 【设备种类】列
        public const string STRING_COLNAME_MACHINE_TYPE = "MACHINE_TYPE";
        // 【班别】列
        public const string STRING_COLNAME_DIV_CODE_CLASS = "DIV_CODE_CLASS";
        // 【班次】列
        public const string STRING_COLNAME_DIV_CODE_CLASSNO = "DIV_CODE_CLASSNO";

        #region A16
        // 【室温】列
        public const string STRING_COLNAME_A16_PERATURE = "PERATURE";
        // 【相对湿度】列
        public const string STRING_COLNAME_A16_HUMIDITY = "HUMIDITY";
        // 【大气压力】列
        public const string STRING_COLNAME_A16_PRESSURE = "PRESSURE";
        // 【平均风速】列
        public const string STRING_COLNAME_A16_WINDSPEED = "WINDSPEED";
        #endregion

        #region A17
        // 【背景】列
        public const string STRING_COLNAME_A17_BACKGROUD = "BACKGROUD";
        // 【光谱计算值】列
        public const string STRING_COLNAME_A17_DATA_COMPUTE = "DATA_COMPUTE";
        // 【部位等级】列
        public const string STRING_COLNAME_A17_POSITION_LEVEL = "POSITION_LEVEL"; 
        // 【产地编码】列
        public const string STRING_COLNAME_A17_AREA_CODE = "AREA_CODE";
        // 【产地名称】列
        public const string STRING_COLNAME_A17_AREA_NAME = "AREA_NAME"; 
        // 【外点】列
        public const string STRING_COLNAME_A17_OUT_POINT = "OUT_POINT"; 
        #endregion

        #endregion

        #region 解析配置文件相关

        // 单值配置数据名称
        public const string STRING_DATA_TYPE_NAME_SINGLERESULT = "singleResult";
        // 统计值配置数据名称
        public const string STRING_DATA_TYPE_NAME_PARAMETER = "parameter";
        #endregion

        // 数据类型
        public const string STRING_MIX_HEADNAME_ROW_TYPE = "数据类型";
        // 行号
        public const string STRING_MIX_HEADNAME_LINE_NO = "行号";
        // 状态
        public const string STRING_MIX_HEADNAME_STATUS = "状态";
        // 报检单号
        public const string STRING_MIX_HEADNAME_ORDER_KEY = "报检单号";
        // 样品号
        public const string STRING_MIX_HEADNAME_SAMPLE_NO = "样品号";
        // 组号
        public const string STRING_MIX_HEADNAME_GROUP_NO = "组号";
        // 组序号
        public const string STRING_MIX_HEADNAME_GROUP_SN = "组序号";
        // 小样号
        public const string STRING_MIX_HEADNAME_SAMPLE_SN = "小样号";
    }
}
