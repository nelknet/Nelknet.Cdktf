namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataFactoryState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataFactory.DataFactoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory">azurerm_data_factory</a>.
    /// </summary>
    type DataFactoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataFactoryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryState<Missing, Missing, Missing>)

        member _.Zero(()) : DataFactoryState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DataFactoryState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#location-1">DataFactory#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: DataFactoryState<Missing, 'Name, 'ResourceGroupName>, value: string) : DataFactoryState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : DataFactoryState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#name-1">DataFactory#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataFactoryState<'Location, Missing, 'ResourceGroupName>, value: string) : DataFactoryState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataFactoryState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#resource_group_name-1">DataFactory#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataFactoryState<'Location, 'Name, Missing>, value: string) : DataFactoryState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataFactoryState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#customer_managed_key_id-1">DataFactory#customer_managed_key_id</a>.
        /// </summary>
        [<CustomOperation "customer_managed_key_id">]
        member _.CustomerManagedKeyId(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: string) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyId <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#customer_managed_key_identity_id-1">DataFactory#customer_managed_key_identity_id</a>.
        /// </summary>
        [<CustomOperation "customer_managed_key_identity_id">]
        member _.CustomerManagedKeyIdentityId(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: string) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CustomerManagedKeyIdentityId <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// github_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#github_configuration-1">DataFactory#github_configuration</a>
        /// </summary>
        [<CustomOperation "github_configuration">]
        member _.GithubConfiguration(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DataFactory.DataFactoryGithubConfiguration) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GithubConfiguration <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// global_parameter block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#global_parameter-1">DataFactory#global_parameter</a> Accepts: azurerm.IResolvable | azurerm.DataFactory.DataFactoryGlobalParameter[]
        /// </summary>
        [<CustomOperation "global_parameter">]
        member _.GlobalParameter(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.GlobalParameter <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#id-1">DataFactory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: string) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// identity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#identity-1">DataFactory#identity</a>
        /// </summary>
        [<CustomOperation "identity">]
        member _.Identity(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DataFactory.DataFactoryIdentity) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Identity <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#managed_virtual_network_enabled-1">DataFactory#managed_virtual_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "managed_virtual_network_enabled">]
        member _.ManagedVirtualNetworkEnabled(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: bool) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedVirtualNetworkEnabled <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#managed_virtual_network_enabled-1">DataFactory#managed_virtual_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "managed_virtual_network_enabled">]
        member _.ManagedVirtualNetworkEnabled(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.ManagedVirtualNetworkEnabled <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#public_network_enabled-1">DataFactory#public_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_enabled">]
        member _.PublicNetworkEnabled(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: bool) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkEnabled <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#public_network_enabled-1">DataFactory#public_network_enabled</a>. Accepts: boolean | azurerm.IResolvable
        /// </summary>
        [<CustomOperation "public_network_enabled">]
        member _.PublicNetworkEnabled(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: HashiCorp.Cdktf.IResolvable) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PublicNetworkEnabled <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#purview_id-1">DataFactory#purview_id</a>.
        /// </summary>
        [<CustomOperation "purview_id">]
        member _.PurviewId(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: string) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.PurviewId <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#tags-1">DataFactory#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#timeouts-1">DataFactory#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DataFactory.DataFactoryTimeouts) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// vsts_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/data_factory#vsts_configuration-1">DataFactory#vsts_configuration</a>
        /// </summary>
        [<CustomOperation "vsts_configuration">]
        member _.VstsConfiguration(state: DataFactoryState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.DataFactory.DataFactoryVstsConfiguration) : DataFactoryState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.VstsConfiguration <- value)
            state : DataFactoryState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: DataFactoryState<Present, Present, Present>) : azurerm.DataFactory.DataFactory =
            let config = azurerm.DataFactory.DataFactoryConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataFactory.DataFactory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataFactory: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataFactoryState<_, _, _>) : azurerm.DataFactory.DataFactory =
            Unchecked.defaultof<azurerm.DataFactory.DataFactory>
