﻿using System.Collections.Generic;
using Xmu.Crms.Shared.Models;

namespace Xmu.Crms.Shared.Service
{
    /**
 * 
 * @author LiuAiqi
 * @version 2.00
 *
 */
    public interface ISchoolService
    {
        /// <summary>
        /// 按城市名称查学校.
        /// @author LiuAiqi
        /// </summary>
        /// <param name="city">城市名称</param>
        /// <returns>list 学校列表</returns>
        List<School> ListSchoolByCity(string city);

        /// <summary>
        /// 添加学校.
        /// @author LiuAiqi
        /// </summary>
        /// <param name="school">学校的信息</param>
        /// <returns>true（添加学校成功）/false（添加学校未成功）</returns>
        bool InsertSchool(School school);

        /// <summary>
        /// 获取省份列表.
        /// @author LiuAiqi
        /// </summary>
        /// <returns>list 省份名称列表</returns>
        List<string> ListProvince();

        /// <summary>
        /// 获取城市列表.
        /// @author LiuAiqi
        /// </summary>
        /// <param name="province">省份名称</param>
        /// <returns>list 城市名称列表</returns>
        List<string> ListCity(string province);

        /// <summary>
        /// 获取学校信息.
        /// @author LiuAiqi
        /// </summary>
        /// <param name="schoolId">学校id</param>
        /// <returns>SchoolBO 学校信息</returns>
        School GetSchoolBySchoolId(long schoolId);
    }
}