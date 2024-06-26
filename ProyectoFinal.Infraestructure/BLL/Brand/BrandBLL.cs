﻿using ActiveDirectoryBack.Core.Interfaces.Services;
using ProyectoFinal.Core.DTOs.Brand;
using ProyectoFinal.Core.DTOs.Response;
using ProyectoFinal.Core.Interfaces.IBLL.Brand;
using ProyectoFinal.Core.Interfaces.IRepository.Brand;

namespace ProyectoFinal.Infraestructure.BLL.Brand
{
    public class BrandBLL : IBrandBLL
    {
        private readonly IBrandRepository _repository;
        private readonly ILogService _logService;
        public BrandBLL(IBrandRepository brandRepository, ILogService logService)
        {
            _repository = brandRepository;
            _logService = logService;
        }

        public async Task<ResponseDTO> CreateBrandBLL(string Description)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {
               
                return await _repository.CreateBrandRepository(Description);
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll CreateBrandBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> DeleteBrandBLL(int IdBrand)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {

                return await _repository.DeleteBrandRepository(IdBrand);
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll DeleteBrandBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> GetBrandByIdBLL(int IdBrand)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {

                return await _repository.GetBrandByIdRepository(IdBrand);
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll GetBrandByIdBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> GetBrandsBLL()
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {

                return await _repository.GetBrandsRepository();
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll GetBrandByIdBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }

        public async Task<ResponseDTO> UpdateBrandBLL(BrandDTO brandDTO)
        {
            ResponseDTO response = new ResponseDTO();
            response.IsSuccess = false;

            try
            {

                return await _repository.UpdateBrandRepository(brandDTO);
            }
            catch (Exception ex)
            {
                _logService.SaveLogsMessages("Se ha producido un error al ejecutar el Bll UpdateBrandBLL: " + ex.Message);
                response.Message += ex.ToString();
                return response;
            }
        }
    }
}
