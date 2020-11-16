using Crowfund.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace Crowfund.Services
{
    public interface IBackerService
    {
        BackerOptions CreateBacker(BackerOptions backerOptions);
        BackerOptions GetBackerById(int id);
        BackerOptions UpdateBacker(BackerOptions backerOptions, int id);
        bool DeleteBacker(int id);
    }
}
