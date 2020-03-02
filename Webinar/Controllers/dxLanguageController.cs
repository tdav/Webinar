using Arch.EntityFrameworkCore.UnitOfWork;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Webinar.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aptex.Controllers
{
    //[Route("api/[controller]/[action]")]
    //public class dxLanguageController : ControllerBase
    //{
    //    private readonly IUnitOfWork db;

    //    public dxLanguageController(IUnitOfWork _db)
    //    {
    //        db = _db;
    //    }


    //    [HttpGet]
    //    public async Task<ActionResult> Get(DataSourceLoadOptions loadOptions)
    //    {
    //        var rp = db.GetRepository<spLanguage>();

    //        var spdistricts = await rp.GetAllAsync() Select(i => new {
    //            i.Id,
    //            i.Name,
    //            i.RegionId,
    //            i.Status,
    //            i.CreateDate,
    //            i.UpdateDate,
    //            i.CreateUser,
    //            i.UpdateUser,
    //            i.Send
    //        });

    //        // Refer to the topic https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
    //        loadOptions.PrimaryKey = new[] { "Id" };
    //        loadOptions.PaginateViaPrimaryKey = true;

    //        return Content(JsonConvert.SerializeObject(await DataSourceLoader.LoadAsync(spdistricts, loadOptions)), "application/json");
    //    }

    //    [HttpPost]
    //    public async Task<IActionResult> Post(string values)
    //    {
    //        var model = new spDistricts();
    //        var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
    //        PopulateModel(model, valuesDict);

    //        if (!TryValidateModel(model))
    //            return BadRequest(GetFullErrorMessage(ModelState));

    //        var result = db.spDistricts.Add(model);
    //        await db.SaveChangesAsync();

    //        return Content(JsonConvert.SerializeObject(result.Entity.Id), "application/json");
    //    }

    //    [HttpPut]
    //    public async Task<IActionResult> Put(int key, string values)
    //    {
    //        var model = await db.spDistricts.FirstOrDefaultAsync(item => item.Id == key);
    //        if (model == null)
    //            return StatusCode(409, "SpDistricts not found");

    //        var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
    //        PopulateModel(model, valuesDict);

    //        if (!TryValidateModel(model))
    //            return BadRequest(GetFullErrorMessage(ModelState));

    //        await db.SaveChangesAsync();
    //        return Ok();
    //    }

    //    [HttpDelete]
    //    public async Task Delete(int key)
    //    {
    //        var model = await db.spDistricts.FirstOrDefaultAsync(item => item.Id == key);

    //        db.spDistricts.Remove(model);
    //        await db.SaveChangesAsync();
    //    }


    //    [HttpGet]
    //    public async Task<IActionResult> SpRegionsLookup(DataSourceLoadOptions loadOptions)
    //    {
    //        var lookup = from i in db.spRegions
    //                     orderby i.Name
    //                     select new
    //                     {
    //                         Value = i.Id,
    //                         Text = i.Name
    //                     };
    //        return Content(JsonConvert.SerializeObject(await DataSourceLoader.LoadAsync(lookup, loadOptions)), "application/json");
    //    }

    //    [HttpGet]
    //    public async Task<IActionResult> SpDrugLookup(DataSourceLoadOptions loadOptions)
    //    {
    //        var lookup = from i in db.spRegions
    //                     orderby i.Name
    //                     select new
    //                     {
    //                         Value = i.Id,
    //                         Text = i.Name
    //                     };
    //        return Content(JsonConvert.SerializeObject(await DataSourceLoader.LoadAsync(lookup, loadOptions)), "application/json");
    //    }

    //    private void PopulateModel(spDistricts model, IDictionary values)
    //    {
    //        string ID = nameof(spDistricts.Id);
    //        string NAME = nameof(spDistricts.Name);
    //        string REGION_ID = nameof(spDistricts.RegionId);
    //        string STATUS = nameof(spDistricts.Status);
    //        string CREATE_DATE = nameof(spDistricts.CreateDate);
    //        string UPDATE_DATE = nameof(spDistricts.UpdateDate);
    //        string CREATE_USER = nameof(spDistricts.CreateUser);
    //        string UPDATE_USER = nameof(spDistricts.UpdateUser);
    //        string SEND = nameof(spDistricts.Send);

    //        if (values.Contains(ID))
    //        {
    //            model.Id = Convert.ToInt32(values[ID]);
    //        }

    //        if (values.Contains(NAME))
    //        {
    //            model.Name = Convert.ToString(values[NAME]);
    //        }

    //        if (values.Contains(REGION_ID))
    //        {
    //            model.RegionId = Convert.ToInt32(values[REGION_ID]);
    //        }

    //        if (values.Contains(STATUS))
    //        {
    //            model.Status = Convert.ToInt32(values[STATUS]);
    //        }

    //        if (values.Contains(CREATE_DATE))
    //        {
    //            model.CreateDate = Convert.ToDateTime(values[CREATE_DATE]);
    //        }

    //        if (values.Contains(UPDATE_DATE))
    //        {
    //            model.UpdateDate = values[UPDATE_DATE] != null ? Convert.ToDateTime(values[UPDATE_DATE]) : (DateTime?)null;
    //        }

    //        if (values.Contains(CREATE_USER))
    //        {
    //            model.CreateUser = new Guid(Convert.ToString(values[CREATE_USER]));
    //        }

    //        if (values.Contains(UPDATE_USER))
    //        {
    //            model.UpdateUser = values[UPDATE_USER] != null ? new Guid(Convert.ToString(values[UPDATE_USER])) : (Guid?)null;
    //        }

    //        if (values.Contains(SEND))
    //        {
    //            model.Send = Convert.ToInt32(values[SEND]);
    //        }
    //    }

    //    private string GetFullErrorMessage(ModelStateDictionary modelState)
    //    {
    //        var messages = new List<string>();

    //        foreach (var entry in modelState)
    //        {
    //            foreach (var error in entry.Value.Errors)
    //                messages.Add(error.ErrorMessage);
    //        }

    //        return String.Join(" ", messages);
    //    }
    }
