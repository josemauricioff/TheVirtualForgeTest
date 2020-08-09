namespace Musicalog.WebApi.ResultEntity
{
    public abstract class BaseResultEntity
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }
}
