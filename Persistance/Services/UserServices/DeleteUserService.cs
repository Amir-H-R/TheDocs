using Persistance.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Services.UserServices
{
    public class DeleteUserService
    {
        private readonly IModel1 _model1;
        public DeleteUserService(IModel1 model1)
        {
                _model1 = model1;
        }
        public ResultDto Execute(int id)
        {
            var user = _model1.People.FirstOrDefault(p=>p.PersonId == id);
            _model1.People.Remove(user);
            _model1.SaveChanges();
            return new ResultDto { Message = "کاربر با موفقیت حذف شد",Success = true};
        }
    }
}
