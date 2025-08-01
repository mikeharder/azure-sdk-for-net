// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// The configuration settings of the Azure Active Directory app registration.
/// </summary>
public partial class AppServiceAadRegistration : ProvisionableConstruct
{
    /// <summary>
    /// The OpenID Connect Issuer URI that represents the entity which issues
    /// access tokens for this application.             When using Azure
    /// Active Directory, this value is the URI of the directory tenant, e.g.
    /// `https://login.microsoftonline.com/v2.0/{tenant-guid}/`.
    /// This URI is a case-sensitive identifier for the token
    /// issuer.             More information on OpenID Connect Discovery:
    /// http://openid.net/specs/openid-connect-discovery-1_0.html
    /// </summary>
    public BicepValue<string> OpenIdIssuer 
    {
        get { Initialize(); return _openIdIssuer!; }
        set { Initialize(); _openIdIssuer!.Assign(value); }
    }
    private BicepValue<string>? _openIdIssuer;

    /// <summary>
    /// The Client ID of this relying party application, known as the
    /// client_id.             This setting is required for enabling OpenID
    /// Connection authentication with Azure Active Directory or
    /// other 3rd party OpenID Connect providers.             More
    /// information on OpenID Connect:
    /// http://openid.net/specs/openid-connect-core-1_0.html
    /// </summary>
    public BicepValue<string> ClientId 
    {
        get { Initialize(); return _clientId!; }
        set { Initialize(); _clientId!.Assign(value); }
    }
    private BicepValue<string>? _clientId;

    /// <summary>
    /// The app setting name that contains the client secret of the relying
    /// party application.
    /// </summary>
    public BicepValue<string> ClientSecretSettingName 
    {
        get { Initialize(); return _clientSecretSettingName!; }
        set { Initialize(); _clientSecretSettingName!.Assign(value); }
    }
    private BicepValue<string>? _clientSecretSettingName;

    /// <summary>
    /// An alternative to the client secret, that is the thumbprint of a
    /// certificate used for signing purposes. This property acts as
    /// a replacement for the Client Secret. It is also optional.
    /// </summary>
    public BicepValue<string> ClientSecretCertificateThumbprintString 
    {
        get { Initialize(); return _clientSecretCertificateThumbprintString!; }
        set { Initialize(); _clientSecretCertificateThumbprintString!.Assign(value); }
    }
    private BicepValue<string>? _clientSecretCertificateThumbprintString;

    /// <summary>
    /// An alternative to the client secret thumbprint, that is the subject
    /// alternative name of a certificate used for signing purposes. This
    /// property acts as             a replacement for the Client Secret
    /// Certificate Thumbprint. It is also optional.
    /// </summary>
    public BicepValue<string> ClientSecretCertificateSubjectAlternativeName 
    {
        get { Initialize(); return _clientSecretCertificateSubjectAlternativeName!; }
        set { Initialize(); _clientSecretCertificateSubjectAlternativeName!.Assign(value); }
    }
    private BicepValue<string>? _clientSecretCertificateSubjectAlternativeName;

    /// <summary>
    /// An alternative to the client secret thumbprint, that is the issuer of a
    /// certificate used for signing purposes. This property acts as
    /// a replacement for the Client Secret Certificate
    /// Thumbprint. It is also optional.
    /// </summary>
    public BicepValue<string> ClientSecretCertificateIssuer 
    {
        get { Initialize(); return _clientSecretCertificateIssuer!; }
        set { Initialize(); _clientSecretCertificateIssuer!.Assign(value); }
    }
    private BicepValue<string>? _clientSecretCertificateIssuer;

    /// <summary>
    /// Creates a new AppServiceAadRegistration.
    /// </summary>
    public AppServiceAadRegistration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AppServiceAadRegistration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _openIdIssuer = DefineProperty<string>("OpenIdIssuer", ["openIdIssuer"]);
        _clientId = DefineProperty<string>("ClientId", ["clientId"]);
        _clientSecretSettingName = DefineProperty<string>("ClientSecretSettingName", ["clientSecretSettingName"]);
        _clientSecretCertificateThumbprintString = DefineProperty<string>("ClientSecretCertificateThumbprintString", ["clientSecretCertificateThumbprint"]);
        _clientSecretCertificateSubjectAlternativeName = DefineProperty<string>("ClientSecretCertificateSubjectAlternativeName", ["clientSecretCertificateSubjectAlternativeName"]);
        _clientSecretCertificateIssuer = DefineProperty<string>("ClientSecretCertificateIssuer", ["clientSecretCertificateIssuer"]);
    }
}
