
using Service.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.WebService.ServiceImpl
{
    public class RJZ_Get_New_Ylzh : ServiceBase
    {
        /// <summary>
        /// 根据旧医疗证号查询家庭成员：(可不做这个功能)
        /// </summary>
        /// <param name="SqlStr">Get_New_Ylzh</param>
        /// <param name="parames"></param>
        /// <param name="split">分割符&</param>
        /// <returns></returns>

// AREA_NO&D401_10_TEMP(旧医疗证号)

// AREA_NO	VARCHAR2(6)	病人地区编码(取前台选择的地区编码)
// D401_10_TEMP	VARCHAR2(18)	旧医疗证号


// 0	成功
// 1	失败    卡号不存在
// 成功：S_Returns =0;D401_10 (分号分隔)
// D401_10: VARCHAR2(18)   新医疗证号



    }
}
