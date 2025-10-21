namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermPrivateDnsResolverState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolverConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver">azurerm_private_dns_resolver</a>.
    /// </summary>
    type DataAzurermPrivateDnsResolverBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermPrivateDnsResolverState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverState<Missing, Missing>)

        member _.Zero(()) : DataAzurermPrivateDnsResolverState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermPrivateDnsResolverState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver#name-1">DataAzurermPrivateDnsResolver#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermPrivateDnsResolverState<Missing, 'ResourceGroupName>, value: string) : DataAzurermPrivateDnsResolverState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver#resource_group_name-1">DataAzurermPrivateDnsResolver#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermPrivateDnsResolverState<'Name, Missing>, value: string) : DataAzurermPrivateDnsResolverState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermPrivateDnsResolverState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver#id-1">DataAzurermPrivateDnsResolver#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermPrivateDnsResolverState<'Name, 'ResourceGroupName>, value: string) : DataAzurermPrivateDnsResolverState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermPrivateDnsResolverState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/private_dns_resolver#timeouts-1">DataAzurermPrivateDnsResolver#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermPrivateDnsResolverState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolverTimeouts) : DataAzurermPrivateDnsResolverState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermPrivateDnsResolverState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermPrivateDnsResolverState<Present, Present>) : azurerm.DataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolver =
            let config = azurerm.DataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolverConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolver(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermPrivateDnsResolver: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermPrivateDnsResolverState<_, _>) : azurerm.DataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolver =
            Unchecked.defaultof<azurerm.DataAzurermPrivateDnsResolver.DataAzurermPrivateDnsResolver>
