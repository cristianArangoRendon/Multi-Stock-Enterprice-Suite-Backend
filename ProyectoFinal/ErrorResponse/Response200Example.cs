﻿using ProyectoFinal.Core.DTOs.Response;
using Swashbuckle.AspNetCore.Filters;

namespace ProyectoFinal.SwaggerExample.ErrorResponse
{
    public class Response200Example : IExamplesProvider<ResponseDTO>
    {
        public ResponseDTO GetExamples()
        {
            return new ResponseDTO
            {
                IsSuccess = true,
                Message = "OK",
                Data = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZEVtcHJlc2EiOiIyOCIsImlkVXN1YXJpbyI6IjExNTUiLCJpZEJvZGVnYSI6IiIsImlkU2VkZSI6IjIzMCIsIm5iZiI6MTcwMDUxNjU4MywiZXhwIjoxNzAwNTM0NTgzLCJpYXQiOjE3MDA1MTY1ODN9.yK4UzjC3eqlGiCFOybBznSWtlA8XJRfHVwvGUfVip1ceyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZEVtcHJlc2EiOiIyOCIsImlkVXN1YXJpbyI6IjExNTUiLCJpZEJvZGVnYSI6IiIsImlkU2VkZSI6IjIzMCIsIm5iZiI6MTcwMDUxNjU4MywiZXhwIjoxNzAwNTM0NTgzLCJpYXQiOjE3MDA1MTY1ODN9.yK4UzjC3eqlGiCFOybBznSWtlA8XJRfHVwvGUfVip1ceyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZEVtcHJlc2EiOiIyOCIsImlkVXN1YXJpbyI6IjExNTUiLCJpZEJvZGVnYSI6IiIsImlkU2VkZSI6IjIzMCIsIm5iZiI6MTcwMDUxNjU4MywiZXhwIjoxNzAwNTM0NTgzLCJpYXQiOjE3MDA1MTY1ODN9.yK4UzjC3eqlGiCFOybBznSWtlA8XJRfHVwvGUfVip1ceyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZEVtcHJlc2EiOiIyOCIsImlkVXN1YXJpbyI6IjExNTUiLCJpZEJvZGVnYSI6IiIsImlkU2VkZSI6IjIzMCIsIm5iZiI6MTcwMDUxNjU4MywiZXhwIjoxNzAwNTM0NTgzLCJpYXQiOjE3MDA1MTY1ODN9.yK4UzjC3eqlGiCFOybBznSWtlA8XJRfHVwvGUfVip1ceyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZEVtcHJlc2EiOiIyOCIsImlkVXN1YXJpbyI6IjExNTUiLCJpZEJvZGVnYSI6IiIsImlkU2VkZSI6IjIzMCIsIm5iZiI6MTcwMDUxNjU4MywiZXhwIjoxNzAwNTM0NTgzLCJpYXQiOjE3MDA1MTY1ODN9.yK4UzjC3eqlGiCFOybBznSWtlA8XJRfHVwvGUfVip1ceyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZEVtcHJlc2EiOiIyOCIsImlkVXN1YXJpbyI6IjExNTUiLCJpZEJvZGVnYSI6IiIsImlkU2VkZSI6IjIzMCIsIm5iZiI6MTcwMDUxNjU4MywiZXhwIjoxNzAwNTM0NTgzLCJpYXQiOjE3MDA1MTY1ODN9.yK4UzjC3eqlGiCFOybBznSWtlA8XJRfHVwvGUfVip1ceyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJJZEVtcHJlc2EiOiIyOCIsImlkVXN1YXJpbyI6IjExNTUiLCJpZEJvZGVnYSI6IiIsImlkU2VkZSI6IjIzMCIsIm5iZiI6MTcwMDUxNjU4MywiZXhwIjoxNzAwNTM0NTgzLCJpYXQiOjE3MDA1MTY1ODN9.yK4UzjC3eqlGiCFOybBznSWtlA8XJRfHVwvGUfVip1c"
            };
        }
    }
}
