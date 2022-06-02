using Microsoft.AspNetCore.Mvc;
using ModelBL;

namespace ModelApi.Controllers
{
    [ApiController]
    [Route("api.[controller")]

    public class ModelController
    {
        private IModelBL _modelBL;
        private IModelAbiJoinBL _maj;

        public ModelController(IModelBL modelBL, IModelAbiJoinBL modelsAbiJoin)
        {
            _modelBL = modelBL;
            _maj = modelsAbiJoin;
        }

        // complete this functionality tomorrow!
    }
}