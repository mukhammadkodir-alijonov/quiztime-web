﻿using Microsoft.AspNetCore.Http;
using QuizTime.Service.Common.Utils;
using QuizTime.Service.Dtos.Accounts;
using QuizTime.Service.Dtos.Teachers;

namespace QuizTime.Service.Interfaces.Admins
{
    public interface IAdminTeacherService
    {
        public Task<bool> RegisterTeacherAsync(TeacherRegisterDto teacherRegisterDto);
        public Task<bool> RegisterAsync(TeacherRegisterDto teacherRegisterDto);
        public Task<bool> DeleteAsync(int id);
        public Task<bool> DeleteImageAsync(int teacherId);
        public Task<bool> UpdateImageAsync(int teacherId, IFormFile formFile);
        public Task<bool> UpdateAsync(TeacherUpdateDto teacherRegisterDto, int id);
        public Task<TeacherViewDto> GetByIdAsync(int id);
        public Task<PagedList<TeacherViewDto>> GetAllAsync(PaginationParams @params);
        public Task<List<TeacherViewDto>> GetFileAllAsync();
        public Task<string> LoginAsync(AccountLoginDto dto);
        public Task<PagedList<TeacherViewDto>> SearchAsync(PaginationParams @params, String name);
        public Task<TeacherViewDto> GetByPhoneNumberAsync(string phoneNumber);

    }

}
