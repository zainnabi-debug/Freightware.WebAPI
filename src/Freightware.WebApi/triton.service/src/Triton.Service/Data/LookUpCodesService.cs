﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Triton.Model.TritonGroup.Tables;
using Triton.Service.Model.TritonGroup.Custom;
using Triton.Service.Utils;

namespace Triton.Service.Data
{
    public class LookUpCodesService
    {
        public static async Task<List<LookUpCodes>> GetAllExistingPositionTypesAsync()
        {
            return await RestApiHelper.GetAsync<List<LookUpCodes>>(new Uri(UrlHelper.Api.RecruitmentApi, $"LookUpCode/GetAllExistingPositionTypes"));
        }

        public static async Task<List<LookUpCodes>> GetAllTransferPromotionTypesAsync()
        {
            return await RestApiHelper.GetAsync<List<LookUpCodes>>(new Uri(UrlHelper.Api.RecruitmentApi, $"LookUpCode/GetAllTransferPromotionTypes"));
        }

        public static async Task<List<LookUpCodes>> GetHRMStatusAsync()
        {
            return await RestApiHelper.GetAsync<List<LookUpCodes>>(new Uri(UrlHelper.Api.RecruitmentApi, $"LookUpCode/HRMStatus"));
        }

        public static async Task<List<LookupCodeCategoriesModel>> GetAllLookUpCodes()
        {
            return await RestApiHelper.GetAsync<List<LookupCodeCategoriesModel>>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.LookUpcodes}/LookUpCodes"));
        }

        public static async Task<bool> InsertLookUpCodeAsync(LookUpCodes model)
        {
            return await RestApiHelper.InsertAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.LookUpcodes}/InsertLookUpCodeAsync/Insert"), model);
        }

        public static async Task<bool> UpdateLookUpCodeAsync(LookUpCodes model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.LookUpcodes}/UpdateLookUpCodeAsync/Update"), model);
        }

        public static async Task<bool> DeleteLookUpCodeAsync(LookUpCodes model)
        {
            return await RestApiHelper.PutAsync(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.LookUpcodes}/DeleteLookUpCodeAsync/Update"), model);
        }

        public static async Task<LookUpCodes> GetLookUpCodeByID(int LookupcodeID)
        {
            return await RestApiHelper.GetAsync<LookUpCodes>(new Uri(UrlHelper.Api.FleetManagementApi, $"{UrlHelper.Controller.LookUpcodes}/GetLookUpCodeByID/{LookupcodeID}"));
        }

        public static async Task<List<LookUpCodes>> GetLookupcodesByCategoryAndSystemID(int LookupcodeCategoryID, int SystemID)
        {
            return await RestApiHelper.GetAsync<List<LookUpCodes>>(new Uri(UrlHelper.Api.TritonApiLegacy, $"Lookupcodes/GetLookUpCodesByCategoryIDandSystemID?LookupcodeCategoryID={LookupcodeCategoryID}&SystemID={SystemID}"));
        }
    }
}
