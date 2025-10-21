namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermAadb2CDirectoryState<'DomainName, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermAadb2CDirectory.DataAzurermAadb2CDirectoryConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/aadb2c_directory">azurerm_aadb2c_directory</a>.
    /// </summary>
    type DataAzurermAadb2CDirectoryBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermAadb2CDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAadb2CDirectoryState<Missing, Missing>)

        member _.Zero(()) : DataAzurermAadb2CDirectoryState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermAadb2CDirectoryState<Missing, Missing>)

        /// <summary>
        /// Domain name of the B2C tenant, including onmicrosoft.com suffix. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/aadb2c_directory#domain_name-1">DataAzurermAadb2CDirectory#domain_name</a>
        /// </summary>
        [<CustomOperation "domain_name">]
        member _.DomainName(state: DataAzurermAadb2CDirectoryState<Missing, 'ResourceGroupName>, value: string) : DataAzurermAadb2CDirectoryState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.DomainName <- value)
            ({ assignments = state.assignments } : DataAzurermAadb2CDirectoryState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/aadb2c_directory#resource_group_name-1">DataAzurermAadb2CDirectory#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermAadb2CDirectoryState<'DomainName, Missing>, value: string) : DataAzurermAadb2CDirectoryState<'DomainName, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermAadb2CDirectoryState<'DomainName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/aadb2c_directory#id-1">DataAzurermAadb2CDirectory#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermAadb2CDirectoryState<'DomainName, 'ResourceGroupName>, value: string) : DataAzurermAadb2CDirectoryState<'DomainName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermAadb2CDirectoryState<'DomainName, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/aadb2c_directory#timeouts-1">DataAzurermAadb2CDirectory#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermAadb2CDirectoryState<'DomainName, 'ResourceGroupName>, value: azurerm.DataAzurermAadb2CDirectory.DataAzurermAadb2CDirectoryTimeouts) : DataAzurermAadb2CDirectoryState<'DomainName, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermAadb2CDirectoryState<'DomainName, 'ResourceGroupName>

        member _.Run(state: DataAzurermAadb2CDirectoryState<Present, Present>) : azurerm.DataAzurermAadb2CDirectory.DataAzurermAadb2CDirectory =
            let config = azurerm.DataAzurermAadb2CDirectory.DataAzurermAadb2CDirectoryConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermAadb2CDirectory.DataAzurermAadb2CDirectory(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermAadb2CDirectory: missing required arguments. Must call: domain_name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermAadb2CDirectoryState<_, _>) : azurerm.DataAzurermAadb2CDirectory.DataAzurermAadb2CDirectory =
            Unchecked.defaultof<azurerm.DataAzurermAadb2CDirectory.DataAzurermAadb2CDirectory>
