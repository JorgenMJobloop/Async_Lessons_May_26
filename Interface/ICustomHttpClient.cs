public interface ICustomHttpClient
{
    /// <summary>
    /// Get data asyncronously from a RestAPI and return the data as a Task
    /// </summary>
    /// <param name="url">url restapi endpoint</param>
    /// <returns>Task</returns>
    Task GetDataAsync(string url);
    /// <summary>
    /// Get data asyncronously from a RestAPI by targeting the id if available in the URL scope
    /// </summary>
    /// <param name="url">url endpoint</param>
    /// <param name="id">id</param>
    /// <returns>Task</returns>
    Task GetDataByIdAsync(string url, int id);
    /// <summary>
    /// Post data to a public RestAPI using the HTTP-POST method
    /// </summary>
    /// <param name="url">url endpoint</param>
    /// <param name="data">datamodel</param>
    /// <returns>Task</returns>
    Task PostDataAsync(string url, Dictionary<string, string> data);
}