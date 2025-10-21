namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> = { assignments: ResizeArray<azurerm.NginxDeployment.NginxDeploymentConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment">azurerm_nginx_deployment</a>.
    /// </summary>
    type NginxDeploymentBuilder(logicalId: string) =
        member _.Yield(_: unit) : NginxDeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NginxDeploymentState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : NginxDeploymentState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : NginxDeploymentState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#location-1">NginxDeployment#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: NginxDeploymentState<Missing, 'Name, 'ResourceGroupName, 'Sku>, value: string) : NginxDeploymentState<Present, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : NginxDeploymentState<Present, 'Name, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#name-1">NginxDeployment#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: NginxDeploymentState<'Location, Missing, 'ResourceGroupName, 'Sku>, value: string) : NginxDeploymentState<'Location, Present, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : NginxDeploymentState<'Location, Present, 'ResourceGroupName, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#resource_group_name-1">NginxDeployment#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: NginxDeploymentState<'Location, 'Name, Missing, 'Sku>, value: string) : NginxDeploymentState<'Location, 'Name, Present, 'Sku> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : NginxDeploymentState<'Location, 'Name, Present, 'Sku>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#sku-1">NginxDeployment#sku</a>.
        /// </summary>
        [<CustomOperation "sku">]
        member _.Sku(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, Missing>, value: string) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, Present> =
            state.assignments.Add(fun config -> config.Sku <- value)
            ({ assignments = state.assignments } : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#automatic_upgrade_channel-1">NginxDeployment#automatic_upgrade_channel</a>.
        /// </summary>
        [<CustomOperation "automatic_upgrade_channel">]
        member _.AutomaticUpgradeChannel(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutomaticUpgradeChannel <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// auto_scale_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#auto_scale_profile-1">NginxDeployment#auto_scale_profile</a> Accepts: azurerm.IResolvable | azurerm.NginxDeployment.NginxDeploymentAutoScaleProfile[]
        /// </summary>
        [<CustomOperation "auto_scale_profile">]
        member _.AutoScaleProfile(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.AutoScaleProfile <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#capacity-1">NginxDeployment#capacity</a>.
        /// </summary>
        [<CustomOperation "capacity">]
        member _.Capacity(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: double) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Capacity <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#diagnose_support_enabled-1">NginxDeployment#diagnose_support_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "diagnose_support_enabled">]
        member _.DiagnoseSupportEnabled(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: bool) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DiagnoseSupportEnabled <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#diagnose_support_enabled-1">NginxDeployment#diagnose_support_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "diagnose_support_enabled">]
        member _.DiagnoseSupportEnabled(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.DiagnoseSupportEnabled <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#email-1">NginxDeployment#email</a>.
        /// </summary>
        [<CustomOperation "email">]
        member _.Email(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Email <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// frontend_private block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#frontend_private-1">NginxDeployment#frontend_private</a> Accepts: azurerm.IResolvable | azurerm.NginxDeployment.NginxDeploymentFrontendPrivate[]
        /// </summary>
        [<CustomOperation "frontend_private">]
        member _.FrontendPrivate(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FrontendPrivate <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// frontend_public block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#frontend_public-1">NginxDeployment#frontend_public</a>
        /// </summary>
        [<CustomOperation "frontend_public">]
        member _.FrontendPublic(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.NginxDeployment.NginxDeploymentFrontendPublic) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.FrontendPublic <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#id-1">NginxDeployment#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#identity-1">NginxDeployment#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.NginxDeployment.NginxDeploymentIdentity) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// logging_storage_account block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#logging_storage_account-1">NginxDeployment#logging_storage_account</a> Accepts: azurerm.IResolvable | azurerm.NginxDeployment.NginxDeploymentLoggingStorageAccount[]
        /// </summary>
        [<CustomOperation "logging_storage_account">]
        member _.LoggingStorageAccount(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.LoggingStorageAccount <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#managed_resource_group-1">NginxDeployment#managed_resource_group</a>.
        /// </summary>
        [<CustomOperation "managed_resource_group">]
        member _.ManagedResourceGroup(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: string) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.ManagedResourceGroup <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// network_interface block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#network_interface-1">NginxDeployment#network_interface</a> Accepts: azurerm.IResolvable | azurerm.NginxDeployment.NginxDeploymentNetworkInterface[]
        /// </summary>
        [<CustomOperation "network_interface">]
        member _.NetworkInterface(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: HashiCorp.Cdktf.IResolvable) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.NetworkInterface <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#tags-1">NginxDeployment#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: seq<string * string>) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/nginx_deployment#timeouts-1">NginxDeployment#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>, value: azurerm.NginxDeployment.NginxDeploymentTimeouts) : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : NginxDeploymentState<'Location, 'Name, 'ResourceGroupName, 'Sku>

        member _.Run(state: NginxDeploymentState<Present, Present, Present, Present>) : azurerm.NginxDeployment.NginxDeployment =
            let config = azurerm.NginxDeployment.NginxDeploymentConfig()
            for setter in state.assignments do
                setter config
            azurerm.NginxDeployment.NginxDeployment(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.nginxDeployment: missing required arguments. Must call: location, name, resource_group_name, sku.", 9999, IsError = true)>]
        member _.Run(_: NginxDeploymentState<_, _, _, _>) : azurerm.NginxDeployment.NginxDeployment =
            Unchecked.defaultof<azurerm.NginxDeployment.NginxDeployment>
