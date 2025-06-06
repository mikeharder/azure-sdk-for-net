// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Sets the number of &apos;Always Ready&apos; instances for a function group
/// or a specific function.
/// </summary>
public partial class FunctionAppAlwaysReadyConfig : ProvisionableConstruct
{
    /// <summary>
    /// Either a function group or a function name is required. For additional
    /// information see https://aka.ms/flexconsumption/alwaysready.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Sets the number of &apos;Always Ready&apos; instances for a given
    /// function group or a specific function. For additional information see
    /// https://aka.ms/flexconsumption/alwaysready.
    /// </summary>
    public BicepValue<float> InstanceCount 
    {
        get { Initialize(); return _instanceCount!; }
        set { Initialize(); _instanceCount!.Assign(value); }
    }
    private BicepValue<float>? _instanceCount;

    /// <summary>
    /// Creates a new FunctionAppAlwaysReadyConfig.
    /// </summary>
    public FunctionAppAlwaysReadyConfig()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of FunctionAppAlwaysReadyConfig.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _name = DefineProperty<string>("Name", ["name"]);
        _instanceCount = DefineProperty<float>("InstanceCount", ["instanceCount"]);
    }
}
