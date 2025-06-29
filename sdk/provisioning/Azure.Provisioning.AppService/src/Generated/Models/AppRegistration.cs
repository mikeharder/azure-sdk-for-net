// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// The configuration settings of the app registration for providers that have
/// app ids and app secrets.
/// </summary>
public partial class AppRegistration : ProvisionableConstruct
{
    /// <summary>
    /// The App ID of the app used for login.
    /// </summary>
    public BicepValue<string> AppId 
    {
        get { Initialize(); return _appId!; }
        set { Initialize(); _appId!.Assign(value); }
    }
    private BicepValue<string>? _appId;

    /// <summary>
    /// The app setting name that contains the app secret.
    /// </summary>
    public BicepValue<string> AppSecretSettingName 
    {
        get { Initialize(); return _appSecretSettingName!; }
        set { Initialize(); _appSecretSettingName!.Assign(value); }
    }
    private BicepValue<string>? _appSecretSettingName;

    /// <summary>
    /// Creates a new AppRegistration.
    /// </summary>
    public AppRegistration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AppRegistration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _appId = DefineProperty<string>("AppId", ["appId"]);
        _appSecretSettingName = DefineProperty<string>("AppSecretSettingName", ["appSecretSettingName"]);
    }
}
