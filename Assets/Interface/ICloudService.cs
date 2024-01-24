using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ICloudService
{
    void Init();
    void GetConfig(Action<string> callback);
    void Login(Action<IUserData> callback);//auth
    void LoginAsGuest(Action<string> callback);
    void LoginWithFacebook(object accessToken, Action<string> callback);
    void UpdateProfile(string objectId, string body, Action<string> callback);
    void GetRanking(string rankingType, int limit, Action<string> callback);
    void API(string url, string body, Action<string> callback);
    void Post(string endPoint, string body, Action<string> callback);
    void Put(string url, string body, Action<string> callback);
    void Get(string url, Action<string> callback);
}
