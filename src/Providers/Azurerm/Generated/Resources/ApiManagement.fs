namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> = { assignments: ResizeArray<azurerm.ApiManagement.ApiManagementConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management">azurerm_api_management</a>.
    /// </summary>
    type ApiManagementBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApiManagementState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ApiManagementState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApiManagementState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#location-1">ApiManagement#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApiManagementState<Missing, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: string) : ApiManagementState<Present, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApiManagementState<Present, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#name-1">ApiManagement#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApiManagementState<'Location, Missing, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: string) : ApiManagementState<'Location, Present, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApiManagementState<'Location, Present, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#publisher_email-1">ApiManagement#publisher_email</a>.
        /// </summary>
        [<CustomOperation "publisher_email">]
        member _.PublisherEmail(state: ApiManagementState<'Location, 'Name, Missing, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: string) : ApiManagementState<'Location, 'Name, Present, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublisherEmail <- value)
            ({ assignments = state.assignments } : ApiManagementState<'Location, 'Name, Present, 'PublisherName, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#publisher_name-1">ApiManagement#publisher_name</a>.
        /// </summary>
        [<CustomOperation "publisher_name">]
        member _.PublisherName(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, Missing, 'ResourceGroupName, 'SkuName>, value: string) : ApiManagementState<'Location, 'Name, 'PublisherEmail, Present, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublisherName <- value)
            ({ assignments = state.assignments } : ApiManagementState<'Location, 'Name, 'PublisherEmail, Present, 'ResourceGroupName, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#resource_group_name-1">ApiManagement#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, Missing, 'SkuName>, value: string) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, Present, 'SkuName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, Present, 'SkuName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#sku_name-1">ApiManagement#sku_name</a>.
        /// </summary>
        [<CustomOperation "sku_name">]
        member _.SkuName(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, Missing>, value: string) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.SkuName <- value)
            ({ assignments = state.assignments } : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, Present>)

        /// <summary>
        /// additional_location block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#additional_location-1">ApiManagement#additional_location</a> Accepts: azurerm.IResolvable | azurerm.ApiManagement.ApiManagementAdditionalLocation[]
        /// </summary>
        [<CustomOperation "additional_location">]
        member _.AdditionalLocation(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.AdditionalLocation <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// certificate block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#certificate-1">ApiManagement#certificate</a> Accepts: azurerm.IResolvable | azurerm.ApiManagement.ApiManagementCertificate[]
        /// </summary>
        [<CustomOperation "certificate">]
        member _.Certificate(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Certificate <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#client_certificate_enabled-1">ApiManagement#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: bool) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#client_certificate_enabled-1">ApiManagement#client_certificate_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "client_certificate_enabled">]
        member _.ClientCertificateEnabled(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.ClientCertificateEnabled <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// delegation block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#delegation-1">ApiManagement#delegation</a>
        /// </summary>
        [<CustomOperation "delegation">]
        member _.Delegation(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementDelegation) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Delegation <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#gateway_disabled-1">ApiManagement#gateway_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "gateway_disabled">]
        member _.GatewayDisabled(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: bool) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.GatewayDisabled <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#gateway_disabled-1">ApiManagement#gateway_disabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "gateway_disabled">]
        member _.GatewayDisabled(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.GatewayDisabled <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// hostname_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#hostname_configuration-1">ApiManagement#hostname_configuration</a>
        /// </summary>
        [<CustomOperation "hostname_configuration">]
        member _.HostnameConfiguration(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementHostnameConfiguration) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.HostnameConfiguration <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#id-1">ApiManagement#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: string) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#identity-1">ApiManagement#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementIdentity) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#min_api_version-1">ApiManagement#min_api_version</a>.
        /// </summary>
        [<CustomOperation "min_api_version">]
        member _.MinApiVersion(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: string) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.MinApiVersion <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#notification_sender_email-1">ApiManagement#notification_sender_email</a>.
        /// </summary>
        [<CustomOperation "notification_sender_email">]
        member _.NotificationSenderEmail(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: string) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.NotificationSenderEmail <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// protocols block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#protocols-1">ApiManagement#protocols</a>
        /// </summary>
        [<CustomOperation "protocols">]
        member _.Protocols(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementProtocols) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Protocols <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#public_ip_address_id-1">ApiManagement#public_ip_address_id</a>.
        /// </summary>
        [<CustomOperation "public_ip_address_id">]
        member _.PublicIpAddressId(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: string) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicIpAddressId <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#public_network_access_enabled-1">ApiManagement#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: bool) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#public_network_access_enabled-1">ApiManagement#public_network_access_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_access_enabled">]
        member _.PublicNetworkAccessEnabled(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: HashiCorp.Cdktf.IResolvable) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.PublicNetworkAccessEnabled <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// security block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#security-1">ApiManagement#security</a>
        /// </summary>
        [<CustomOperation "security">]
        member _.Security(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementSecurity) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Security <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// sign_in block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#sign_in-1">ApiManagement#sign_in</a>
        /// </summary>
        [<CustomOperation "sign_in">]
        member _.SignIn(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementSignIn) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.SignIn <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// sign_up block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#sign_up-1">ApiManagement#sign_up</a>
        /// </summary>
        [<CustomOperation "sign_up">]
        member _.SignUp(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementSignUp) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.SignUp <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#tags-1">ApiManagement#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: seq<string * string>) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// tenant_access block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#tenant_access-1">ApiManagement#tenant_access</a>
        /// </summary>
        [<CustomOperation "tenant_access">]
        member _.TenantAccess(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementTenantAccess) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.TenantAccess <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#timeouts-1">ApiManagement#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementTimeouts) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// virtual_network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#virtual_network_configuration-1">ApiManagement#virtual_network_configuration</a>
        /// </summary>
        [<CustomOperation "virtual_network_configuration">]
        member _.VirtualNetworkConfiguration(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: azurerm.ApiManagement.ApiManagementVirtualNetworkConfiguration) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.VirtualNetworkConfiguration <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#virtual_network_type-1">ApiManagement#virtual_network_type</a>.
        /// </summary>
        [<CustomOperation "virtual_network_type">]
        member _.VirtualNetworkType(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: string) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.VirtualNetworkType <- value)
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/api_management#zones-1">ApiManagement#zones</a>.
        /// </summary>
        [<CustomOperation "zones">]
        member _.Zones(state: ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>, value: seq<string>) : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName> =
            state.assignments.Add(fun config -> config.Zones <- (value |> Seq.toArray))
            state : ApiManagementState<'Location, 'Name, 'PublisherEmail, 'PublisherName, 'ResourceGroupName, 'SkuName>

        member _.Run(state: ApiManagementState<Present, Present, Present, Present, Present, Present>) : azurerm.ApiManagement.ApiManagement =
            let config = azurerm.ApiManagement.ApiManagementConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApiManagement.ApiManagement(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.apiManagement: missing required arguments. Must call: location, name, publisher_email, publisher_name, resource_group_name, sku_name.", 9999, IsError = true)>]
        member _.Run(_: ApiManagementState<_, _, _, _, _, _>) : azurerm.ApiManagement.ApiManagement =
            Unchecked.defaultof<azurerm.ApiManagement.ApiManagement>
