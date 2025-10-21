namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DevCenterCatalog.DevCenterCatalogConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog">azurerm_dev_center_catalog</a>.
    /// </summary>
    type DevCenterCatalogBuilder(logicalId: string) =
        member _.Yield(_: unit) : DevCenterCatalogState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterCatalogState<Missing, Missing, Missing>)

        member _.Zero(()) : DevCenterCatalogState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : DevCenterCatalogState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#dev_center_id-1">DevCenterCatalog#dev_center_id</a>.
        /// </summary>
        [<CustomOperation "dev_center_id">]
        member _.DevCenterId(state: DevCenterCatalogState<Missing, 'Name, 'ResourceGroupName>, value: string) : DevCenterCatalogState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DevCenterId <- value)
            ({ assignments = state.assignments } : DevCenterCatalogState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#name-1">DevCenterCatalog#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DevCenterCatalogState<'DevCenterId, Missing, 'ResourceGroupName>, value: string) : DevCenterCatalogState<'DevCenterId, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DevCenterCatalogState<'DevCenterId, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#resource_group_name-1">DevCenterCatalog#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DevCenterCatalogState<'DevCenterId, 'Name, Missing>, value: string) : DevCenterCatalogState<'DevCenterId, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DevCenterCatalogState<'DevCenterId, 'Name, Present>)

        /// <summary>
        /// catalog_adogit block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#catalog_adogit-1">DevCenterCatalog#catalog_adogit</a>
        /// </summary>
        [<CustomOperation "catalog_adogit">]
        member _.CatalogAdogit(state: DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName>, value: azurerm.DevCenterCatalog.DevCenterCatalogCatalogAdogit) : DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CatalogAdogit <- value)
            state : DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// catalog_github block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#catalog_github-1">DevCenterCatalog#catalog_github</a>
        /// </summary>
        [<CustomOperation "catalog_github">]
        member _.CatalogGithub(state: DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName>, value: azurerm.DevCenterCatalog.DevCenterCatalogCatalogGithub) : DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.CatalogGithub <- value)
            state : DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#id-1">DevCenterCatalog#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName>, value: string) : DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/dev_center_catalog#timeouts-1">DevCenterCatalog#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName>, value: azurerm.DevCenterCatalog.DevCenterCatalogTimeouts) : DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DevCenterCatalogState<'DevCenterId, 'Name, 'ResourceGroupName>

        member _.Run(state: DevCenterCatalogState<Present, Present, Present>) : azurerm.DevCenterCatalog.DevCenterCatalog =
            let config = azurerm.DevCenterCatalog.DevCenterCatalogConfig()
            for setter in state.assignments do
                setter config
            azurerm.DevCenterCatalog.DevCenterCatalog(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.devCenterCatalog: missing required arguments. Must call: dev_center_id, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DevCenterCatalogState<_, _, _>) : azurerm.DevCenterCatalog.DevCenterCatalog =
            Unchecked.defaultof<azurerm.DevCenterCatalog.DevCenterCatalog>
