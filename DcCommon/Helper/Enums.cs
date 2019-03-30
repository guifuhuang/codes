using System;

namespace DcCommon.Helper
{
    /// <summary>
    /// 仪器类型
    /// </summary>

    [Serializable]
    public enum DcType
    {
        /// <summary>
        /// 摩擦系数仪
        /// </summary>
        A00 = 0,
        /// <summary>
        /// 雾度仪
        /// </summary>
        A01 = 1,
        /// <summary>
        /// 拉力机
        /// </summary>
        A02 = 2,
        /// <summary>
        /// 白度仪
        /// </summary>
        A03 = 3,
        /// <summary>
        /// 光泽度仪
        /// </summary>
        A04 = 4,
        /// <summary>
        /// QTM综合测试台
        /// </summary>
        A05 = 5,
        /// <summary>
        /// 单丝线密度仪
        /// </summary>
        A06 = 6,
        /// <summary>
        /// 动态接触角测试仪
        /// </summary>
        A07 = 7,
        /// <summary>
        /// 数码显微成像测量系统
        /// </summary>
        A08 = 8,
        /// <summary>
        /// 条码仪
        /// </summary>
        A09 = 9,
        /// <summary>
        /// 激光粒度分析仪
        /// </summary>
        A10 = 10,
        /// <summary>
        /// 透气度测定仪
        /// </summary>
        A11 = 11,
        /// <summary>
        /// 色差仪
        /// </summary>
        A12 = 12,
        /// <summary>
        /// 压痕测试仪
        /// </summary>
        A13 = 13,
        /// <summary>
        /// 便携式分光密度仪
        /// </summary>
        A14 = 14,
        /// <summary>
        /// 直线吸烟机
        /// </summary>
        A15 = 15,
        /// <summary>
        /// 转盘吸烟机
        /// </summary>
        A16 = 16,
        /// <summary>
        /// Antaris傅里叶变换近红外光谱仪
        /// </summary>
        A17 = 17,
        /// <summary>
        /// 数字投影仪
        /// </summary>
        A18 = 18,
        /// <summary>
        /// 密度折光联用仪
        /// </summary>
        A19 = 19,
        /// <summary>
        /// 烟支含末率测量仪
        /// </summary>
        A20 = 20,
        /// <summary>
        /// 长度仪
        /// </summary>
        A21 = 21,
        /// <summary>
        /// 纸张强度测试仪
        /// </summary>
        A22 = 22,
        /// <summary>
        /// 纸张粗糙度测试仪
        /// </summary>
        A23 = 23,
        /// <summary>
        /// 扩散系数测定仪
        /// </summary>
        A24 = 24,
        /// <summary>
        /// 胶囊颗粒强度检测仪
        /// </summary>
        A25 = 25,
        /// <summary>
        /// 烟用胶囊滤棒综合检测仪
        /// </summary>
        A26 = 26,
    }
    /// <summary>
    /// Qtm值类型描述
    /// </summary>
    [Serializable]
    public enum QTMValueTypeDesc
    {
        /// <summary>
        /// 重量
        /// </SUMMARY>
        WTg = 0,
        /// <SUMMARY>
        /// 圆周
        /// </SUMMARY>
        SIZEmmL = 1,
        /// <SUMMARY>
        /// 椭圆度
        /// </SUMMARY>
        OVALmm = 2,
        /// <SUMMARY>
        /// 总通风
        /// </SUMMARY>
        VENT = 3,
        /// <SUMMARY>
        /// 嘴通风
        /// </SUMMARY>
        TIP = 4,
        /// <SUMMARY>
        /// 纸通风
        /// </SUMMARY>
        ENV = 5,
        /// <SUMMARY>
        /// 开吸阻(kPa)
        /// </SUMMARY>
        PDOkPa = 6,
        /// <SUMMARY>
        /// 开吸阻(mm)
        /// </SUMMARY>
        PDOmm = 7,
        /// <SUMMARY>
        /// 闭吸阻(mm)
        /// </SUMMARY>
        PDCmm = 8,
        /// <SUMMARY>
        /// 压降单支
        /// </SUMMARY>
        PDmm = 9,
        /// <SUMMARY>
        /// 硬度
        /// </SUMMARY>
        HARD = 10
    }
    /// <summary>
    /// 特殊物料设置类别
    /// </summary>
    [Serializable]
    public enum SpecialMaterialSettingType
    {
        /// <summary>
        /// 客户端设备配置
        /// </SUMMARY>
        ClientMachineSetting = 0,
    }
    /// <summary>
    /// 数据分析方法
    /// </summary>
    [Serializable]
    public enum AnalyticMethod
    {
        /// <summary>
        /// 默认或者第一个
        /// </SUMMARY>
        FirstOrDefault = 0,
        /// <SUMMARY>
        /// 根据文件内容动态设定
        /// </SUMMARY>
        DynamicByConent = 1,
    }
    /// <summary>
    /// 混合Table行类型
    /// </summary>
    [Serializable]
    public enum MixTableRowType
    {

        /// <summary>
        /// 参数名
        /// </SUMMARY>
        paraName = 1,
        /// <SUMMARY>
        /// 参数值
        /// </SUMMARY>
        paraValue = 2,
        /// <SUMMARY>
        /// 统计名
        /// </SUMMARY>
        groupName = 3,
        /// <SUMMARY>
        /// 统计值
        /// </SUMMARY>
        groupValue = 4,
        /// <SUMMARY>
        /// 单值名
        /// </SUMMARY>
        singleName = 5,
        /// <SUMMARY>
        /// 单值
        /// </SUMMARY>
        singleValue = 6,
    }
    /// <summary>
    /// 文件类型
    /// </summary>
    [Serializable]
    public enum FileType
    {
        /// <summary>
        /// HTM
        /// </SUMMARY>
        HTM = 1,
        /// <SUMMARY>
        /// CSV
        /// </SUMMARY>
        CSV = 2,
        /// <SUMMARY>
        /// XLS
        /// </SUMMARY>
        XLS = 3,
        /// <SUMMARY>
        /// XLSX
        /// </SUMMARY>
        XLSX = 4,
        /// <SUMMARY>
        /// XPS
        /// </SUMMARY>
        XPS = 5,
        /// <SUMMARY>
        /// TXT
        /// </SUMMARY>
        TXT = 6,
    }
    /// <summary>
    /// 区分类型
    /// </summary>
    [Serializable]
    public enum DIVType
    {
        /// <summary>
        /// 班别
        /// </summary>
        Class = 0,
        /// <summary>
        /// 班次
        /// </summary>
        ClassNo = 1,
        /// <summary>
        /// 标样
        /// </summary>
        Std = 2,
        /// <summary>
        /// 检测环节
        /// </summary>
        DetectionLink = 3,
        /// <summary>
        /// 片烟区域
        /// </summary>
        TobaccoStripsPlace = 4,
        /// <summary>
        /// 七害项
        /// </summary>
        Harmful = 5,
    }
    /// <summary>
    /// 报检单类型
    /// </summary>
    [Serializable]
    public enum InspectionType
    {
        /// <summary>
        /// 烟用材料交收检验报检单
        /// </summary>
        TobaccoMaterials = 0,
        /// <summary>
        /// 成品质量检验报检单
        /// </summary>
        EndTobacco = 1,
        /// <summary>
        /// 研发日常检测申请单
        /// </summary>
        RoutineCheck = 2,
        /// <summary>
        /// 原烟进货检验报检单
        /// </summary>
        Materials = 3,
    }
    /// <summary>
    /// 检测记录的类型
    /// </summary>
    [Serializable]
    public enum RecordType
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 废弃
        /// </summary>
        Discard = 1,
        /// <summary>
        /// 复检
        /// </summary>
        Recheck = 2,
    }
    /// <summary>
    /// 报检单状态的类型
    /// </summary>
    [Serializable]
    public enum InspectionStatusType
    {
        /// <summary>
        /// 正常
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 复检
        /// </summary>
        Recheck = 1,
        /// <summary>
        /// 红冲
        /// </summary>
        Back = -1,
    }
    /// <summary>
    /// 报检单检测任务状态的类型
    /// </summary>
    [Serializable]
    public enum InspectionTaskStatusType
    {
        /// <summary>
        /// 取回
        /// </summary>
        RollBack = -1,
        /// <summary>
        /// 未检
        /// </summary>
        Normal = 0,
        /// <summary>
        /// 已检
        /// </summary>
        Finished = 1,
        /// <summary>
        /// 已回传
        /// </summary>
        Uploaded = 2,
    }
    /// <summary>
    /// 接口执行结果的类型
    /// </summary>
    [Serializable]
    public enum IOResultType
    {
        /// <summary>
        /// 执行中
        /// </summary>
        Waiting = 0,
        /// <summary>
        /// 成功
        /// </summary>
        Success = 1,
        /// <summary>
        /// 失败
        /// </summary>
        Failure = -1,
    }
    /// <summary>
    /// 比较类型
    /// </summary>
    [Serializable]
    public enum ComparisonType
    {
        /// <summary>
        /// 不等于
        /// </summary>
        UnEqualTo = -1,
        /// <summary>
        /// 等于
        /// </summary>
        EqualTo = 0,
        /// <summary>
        /// 小于
        /// </summary>
        LessThan = 1,
        /// <summary>
        /// 大于
        /// </summary>
        GreaterThan = 2,
        /// <summary>
        /// 小于等于
        /// </summary>
        LessThanOrEqualTo = 3,
        /// <summary>
        /// 大于等于
        /// </summary>
        GreaterThanOrEqualTo = 4,
    }
    /// <summary>
    /// 数据类型
    /// </summary>
    [Serializable]
    public enum DataType
    {
        /// <summary>
        /// String
        /// </summary>
        String = 0,
        /// <summary>
        /// Decimal
        /// </summary>
        Decimal = 1,
        /// <summary>
        /// Int
        /// </summary>
        Int = 2,
    }
    /// <summary>
    /// 设备显示数据的类型
    /// </summary>
    [Serializable]
    public enum MachineColumnCategory
    {
        /// <summary>
        /// Common
        /// </summary>
        Common = 0,
        /// <summary>
        /// Details
        /// </summary>
        Details = 1,
        /// <summary>
        /// Summary
        /// </summary>
        Summary = 2,
    }

    /// <summary>
    /// Antaris傅里叶变换近红外光谱仪 光谱数据类型
    /// </summary>
    [Serializable]
    public enum AntarisDataCategory
    {
        /// <summary>
        /// 光谱文件
        /// </summary>
        Spectra = 1,
        /// <summary>
        /// 100%直线
        /// </summary>
        StraightLine = 2,
        /// <summary>
        /// 背景
        /// </summary>
        Background = 3,
        /// <summary>
        /// 单光束
        /// </summary>
        SingleBeam = 4,
    }
    /// <summary>
    /// Antaris傅里叶变换近红外光谱仪 参数类别
    /// </summary>
    [Serializable]
    public enum MataLabParamCategory
    {
        /// <summary>
        /// 部位模型
        /// </summary>
        Position = 1,
        /// <summary>
        /// 化学值模型
        /// </summary>
        Chemistry = 2,
        /// <summary>
        /// 背景
        /// </summary>
        Background = 3,
        /// <summary>
        /// 感官
        /// </summary>
        Feel = 4,
        /// <summary>
        /// 香型
        /// </summary>
        Odor = 5,
        /// <summary>
        /// 外点
        /// </summary>
        OutPoint = 6,
    }
    /// <summary>
    /// 报检单类型
    /// </summary>
    [Serializable]
    public enum UploadFileType
    {
        /// <summary>
        /// MatLabDll
        /// </summary>
        MatLabDll = 0,
        /// <summary>
        /// LocalLog
        /// </summary>
        LocalLog = 1,
    }
}
