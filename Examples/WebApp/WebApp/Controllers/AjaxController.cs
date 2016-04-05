using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApp.Models;
using WebApp.bizObjects;

using Unsafe.Data;
using Unsafe.Data.Common.Validators;
using Unsafe.MVC;

namespace WebApp.Controllers
{

    public class AjaxController : Controller
    {

        #region api - checkSomeID

        [HttpPost()]
        public ActionResult checkSomeID(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valID>().isValid; // note: this validator is in the Unsafe.Data.Common.Validators namespace

            return Json(ret);
        }

        #endregion
        #region api - checkPosInt

        [HttpPost()]
        public ActionResult checkPosInt(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valPosInteger>().isValid; // note: this is a custom validator in this project's bizObjects namespace

            return Json(ret);
        }

        #endregion
        #region api - checkNegInt

        [HttpPost()]
        public ActionResult checkNegInt(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valNegInteger>().isValid; // note: this is a custom validator in this project's bizObjects namespace

            return Json(ret);
        }

        #endregion
        #region api - checkSimpleWord

        [HttpPost()]
        public ActionResult checkSimpleWord(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valSingleWord>().isValid; // note: this validator is in the Unsafe.Data.Common.Validators namespace

            return Json(ret);
        }

        #endregion
        #region api - checkSimpleSentence

        [HttpPost()]
        public ActionResult checkSimpleSentence(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valSimpleComment>().isValid; // note: this validator is in the Unsafe.Data.Common.Validators namespace

            return Json(ret);
        }

        #endregion



        #region api - checkDangerousID

        [HttpPost()]
        [ValidateInput(false)]
        public ActionResult checkDangerousID(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valID>().isValid; // note: this validator is in the Unsafe.Data.Common.Validators namespace

            return Json(ret);
        }

        #endregion
        #region api - checkDangerousPosInt

        [HttpPost()]
        [ValidateInput(false)]
        public ActionResult checkDangerousPosInt(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valPosInteger>().isValid; // note: this is a custom validator in this project's bizObjects namespace

            return Json(ret);
        }

        #endregion
        #region api - checkDangerousNegInt

        [HttpPost()]
        [ValidateInput(false)]
        public ActionResult checkDangerousNegInt(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valNegInteger>().isValid; // note: this is a custom validator in this project's bizObjects namespace

            return Json(ret);
        }

        #endregion
        #region api - checkDangerousWord

        [HttpPost()]
        [ValidateInput(false)]
        public ActionResult checkDangerousWord(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valSingleWord>().isValid; // note: this validator is in the Unsafe.Data.Common.Validators namespace

            return Json(ret);
        }

        #endregion
        #region api - checkDangerousSentence

        [HttpPost()]
        [ValidateInput(false)]
        public ActionResult checkDangerousSentence(UnsafeValue testValue)
        {
            mdlTestResult ret = new mdlTestResult();

            ret.testResult = testValue.Validate<valSimpleComment>().isValid; // note: this validator is in the Unsafe.Data.Common.Validators namespace

            return Json(ret);
        }

        #endregion

    }

}