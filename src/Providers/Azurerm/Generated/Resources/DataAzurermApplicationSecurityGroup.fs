namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAzurermApplicationSecurityGroupState<'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.DataAzurermApplicationSecurityGroup.DataAzurermApplicationSecurityGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_security_group">azurerm_application_security_group</a>.
    /// </summary>
    type DataAzurermApplicationSecurityGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAzurermApplicationSecurityGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApplicationSecurityGroupState<Missing, Missing>)

        member _.Zero(()) : DataAzurermApplicationSecurityGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAzurermApplicationSecurityGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_security_group#name-1">DataAzurermApplicationSecurityGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: DataAzurermApplicationSecurityGroupState<Missing, 'ResourceGroupName>, value: string) : DataAzurermApplicationSecurityGroupState<Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : DataAzurermApplicationSecurityGroupState<Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_security_group#resource_group_name-1">DataAzurermApplicationSecurityGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: DataAzurermApplicationSecurityGroupState<'Name, Missing>, value: string) : DataAzurermApplicationSecurityGroupState<'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : DataAzurermApplicationSecurityGroupState<'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_security_group#id-1">DataAzurermApplicationSecurityGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAzurermApplicationSecurityGroupState<'Name, 'ResourceGroupName>, value: string) : DataAzurermApplicationSecurityGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAzurermApplicationSecurityGroupState<'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/data-sources/application_security_group#timeouts-1">DataAzurermApplicationSecurityGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: DataAzurermApplicationSecurityGroupState<'Name, 'ResourceGroupName>, value: azurerm.DataAzurermApplicationSecurityGroup.DataAzurermApplicationSecurityGroupTimeouts) : DataAzurermApplicationSecurityGroupState<'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : DataAzurermApplicationSecurityGroupState<'Name, 'ResourceGroupName>

        member _.Run(state: DataAzurermApplicationSecurityGroupState<Present, Present>) : azurerm.DataAzurermApplicationSecurityGroup.DataAzurermApplicationSecurityGroup =
            let config = azurerm.DataAzurermApplicationSecurityGroup.DataAzurermApplicationSecurityGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.DataAzurermApplicationSecurityGroup.DataAzurermApplicationSecurityGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.dataAzurermApplicationSecurityGroup: missing required arguments. Must call: name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: DataAzurermApplicationSecurityGroupState<_, _>) : azurerm.DataAzurermApplicationSecurityGroup.DataAzurermApplicationSecurityGroup =
            Unchecked.defaultof<azurerm.DataAzurermApplicationSecurityGroup.DataAzurermApplicationSecurityGroup>
