using AutoMapper;
using Order.ApplicationCore.Model.Request;

namespace Order.API.Helper;

public class ApplicationMapper:Profile
{
    public ApplicationMapper()
    {
        CreateMap<ApplicationCore.Entity.Order, ApplicationCore.Model.Request.OrderRequestModel>().ReverseMap();
        CreateMap<ApplicationCore.Entity.Order, ApplicationCore.Model.Request.OrderRequestModel>().ReverseMap();
    }
}