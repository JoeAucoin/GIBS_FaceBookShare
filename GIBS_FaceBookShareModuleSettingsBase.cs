/*
' Copyright (c) 2021  GIBS.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using DotNetNuke.Entities.Modules;

namespace GIBS.Modules.GIBS_FaceBookShare
{
    public class GIBS_FaceBookShareModuleSettingsBase : ModuleSettingsBase
    {

        public string Content
        {
            get
            {
                if (Settings.Contains("Content"))
                    return Settings["Content"].ToString();
                return string.Empty;
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateModuleSetting(ModuleId, "Content", value.ToString());
            }
        }



        public string Token
        {
            get
            {
                if (Settings.Contains("Token"))
                    return Settings["Token"].ToString();
                return string.Empty;
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateModuleSetting(ModuleId, "Token", value.ToString());
            }
        }
    }
}