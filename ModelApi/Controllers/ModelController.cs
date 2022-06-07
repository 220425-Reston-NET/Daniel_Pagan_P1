using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using ModelBL;
using ModelGundam;

namespace ModelApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ModelController : ControllerBase
    {
        private IModelBL _modelBL;
        private IModelAbiJoinBL _maj;

        public ModelController(IModelBL modelBL, IModelAbiJoinBL modelAbiJoin)
        {
            _modelBL = modelBL;
            _maj = modelAbiJoin;
        }

        [HttpGet("GetAllModel")]
        public IActionResult GetAllModel()
        {
            try
            {
                List<Model> listOfCurrentModel = _modelBL.GetAllModel();
                return Ok(listOfCurrentModel);
            }
            catch (SqlException)
            {
                return NotFound("No Model Exist");
                
            }
        }

        [HttpPost("AddModel")]
        public IActionResult AddModel([FromBody] Model m_model)
        {
            try
            {
                _modelBL.AddModel(m_model);

                return Created("Model was Added", m_model);
            }
            catch (SqlException)
            {
                return Conflict();
                
            }
        }

        [HttpGet("SearchModelByName")]
        public IActionResult SearchModel([FromQuery] string modelName)
        {
            try
            {
                return Ok(_modelBL.SearchModelByName(modelName));
            }
            catch (SqlException)
            {
                
                return Conflict();
            }
        }

        [HttpPut("ReplenishAmmo")]
        public IActionResult ReplenishAmmo([FromQuery] int a_Ammo, [FromQuery] int a_abilityID, [FromQuery] int m_modelID)
        {
            Model found = _modelBL.SearchModelByID(m_modelID);
            if (found == null)
            {
                return NotFound("Model was not found!");
            }
            else
            {
                try
                {
                    _maj.ReplenishAbilityAmmo(a_Ammo, a_abilityID, m_modelID);

                    return Ok();
                }
                catch (SqlException)
                {
                    
                    return Conflict();
                }
            }
        }

        [HttpPut("ReplenishArmor")]
        public IActionResult ReplenishArmor([FromQuery] int a_Armor, [FromQuery] int a_abilityID, [FromQuery] int m_modelID)
        {
            Model found = _modelBL.SearchModelByID(m_modelID);

            if (found == null)
            {
                return NotFound("Model was not found!");
            }
            else
            {
                try
                {
                    _maj.ReplenishAbilityArmor(a_Armor, a_abilityID, m_modelID);

                    return Ok();
                }
                catch (SqlException)
                {
                    
                    return Conflict();
                }
            }
        }
    }
}