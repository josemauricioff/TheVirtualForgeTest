namespace Musicalog.WebApi.ResultEntity
{
    public abstract class BaseResultEntity
    {
        public bool Sucsess { get; set; }
        public string ErrorMessage { get; set; }
    }
}
