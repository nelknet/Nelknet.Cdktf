namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> = { assignments: ResizeArray<azurerm.SpringCloudApp.SpringCloudAppConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app">azurerm_spring_cloud_app</a>.
    /// </summary>
    type SpringCloudAppBuilder(logicalId: string) =
        member _.Yield(_: unit) : SpringCloudAppState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppState<Missing, Missing, Missing>)

        member _.Zero(()) : SpringCloudAppState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : SpringCloudAppState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#name-1">SpringCloudApp#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SpringCloudAppState<Missing, 'ResourceGroupName, 'ServiceName>, value: string) : SpringCloudAppState<Present, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : SpringCloudAppState<Present, 'ResourceGroupName, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#resource_group_name-1">SpringCloudApp#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: SpringCloudAppState<'Name, Missing, 'ServiceName>, value: string) : SpringCloudAppState<'Name, Present, 'ServiceName> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : SpringCloudAppState<'Name, Present, 'ServiceName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#service_name-1">SpringCloudApp#service_name</a>.
        /// </summary>
        [<CustomOperation "service_name">]
        member _.ServiceName(state: SpringCloudAppState<'Name, 'ResourceGroupName, Missing>, value: string) : SpringCloudAppState<'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.ServiceName <- value)
            ({ assignments = state.assignments } : SpringCloudAppState<'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#addon_json-1">SpringCloudApp#addon_json</a>.
        /// </summary>
        [<CustomOperation "addon_json">]
        member _.AddonJson(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: string) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.AddonJson <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// custom_persistent_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#custom_persistent_disk-1">SpringCloudApp#custom_persistent_disk</a> Accepts: azurerm.IResolvable | azurerm.SpringCloudApp.SpringCloudAppCustomPersistentDisk[]
        /// </summary>
        [<CustomOperation "custom_persistent_disk">]
        member _.CustomPersistentDisk(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.CustomPersistentDisk <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#https_only-1">SpringCloudApp#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: bool) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#https_only-1">SpringCloudApp#https_only</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "https_only">]
        member _.HttpsOnly(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.HttpsOnly <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#id-1">SpringCloudApp#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: string) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#identity-1">SpringCloudApp#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: azurerm.SpringCloudApp.SpringCloudAppIdentity) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// ingress_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#ingress_settings-1">SpringCloudApp#ingress_settings</a>
        /// </summary>
        [<CustomOperation "ingress_settings">]
        member _.IngressSettings(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: azurerm.SpringCloudApp.SpringCloudAppIngressSettings) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.IngressSettings <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#is_public-1">SpringCloudApp#is_public</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_public">]
        member _.IsPublic(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: bool) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.IsPublic <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#is_public-1">SpringCloudApp#is_public</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "is_public">]
        member _.IsPublic(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.IsPublic <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// persistent_disk block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#persistent_disk-1">SpringCloudApp#persistent_disk</a>
        /// </summary>
        [<CustomOperation "persistent_disk">]
        member _.PersistentDisk(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: azurerm.SpringCloudApp.SpringCloudAppPersistentDisk) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.PersistentDisk <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#public_endpoint_enabled-1">SpringCloudApp#public_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_endpoint_enabled">]
        member _.PublicEndpointEnabled(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: bool) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.PublicEndpointEnabled <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#public_endpoint_enabled-1">SpringCloudApp#public_endpoint_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_endpoint_enabled">]
        member _.PublicEndpointEnabled(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.PublicEndpointEnabled <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#timeouts-1">SpringCloudApp#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: azurerm.SpringCloudApp.SpringCloudAppTimeouts) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#tls_enabled-1">SpringCloudApp#tls_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls_enabled">]
        member _.TlsEnabled(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: bool) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.TlsEnabled <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/spring_cloud_app#tls_enabled-1">SpringCloudApp#tls_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "tls_enabled">]
        member _.TlsEnabled(state: SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>, value: HashiCorp.Cdktf.IResolvable) : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName> =
            state.assignments.Add(fun config -> config.TlsEnabled <- value)
            state : SpringCloudAppState<'Name, 'ResourceGroupName, 'ServiceName>

        member _.Run(state: SpringCloudAppState<Present, Present, Present>) : azurerm.SpringCloudApp.SpringCloudApp =
            let config = azurerm.SpringCloudApp.SpringCloudAppConfig()
            for setter in state.assignments do
                setter config
            azurerm.SpringCloudApp.SpringCloudApp(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.springCloudApp: missing required arguments. Must call: name, resource_group_name, service_name.", 9999, IsError = true)>]
        member _.Run(_: SpringCloudAppState<_, _, _>) : azurerm.SpringCloudApp.SpringCloudApp =
            Unchecked.defaultof<azurerm.SpringCloudApp.SpringCloudApp>
