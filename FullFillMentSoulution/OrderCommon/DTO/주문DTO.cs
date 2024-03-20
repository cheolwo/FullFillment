using Common.DTO;
using Common.DTO.Interface;

namespace 주문Common.DTO.주문대기
{
    public class 주문CudDTO
    {
        
    }
    public class Create주문DTO : 주문CudDTO, ICreateDTO
    {
    }
    public class Update주문DTO : 주문CudDTO, IUpdateDTO
    {
    }
    public class Delete주문DTO : 주문CudDTO, IDeleteDTO
    {
    }
    public class Read주문DTO : ReadDto
    {
    }
}
