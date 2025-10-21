namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName> = { assignments: ResizeArray<azurerm.ApplicationSecurityGroup.ApplicationSecurityGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_security_group">azurerm_application_security_group</a>.
    /// </summary>
    type ApplicationSecurityGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : ApplicationSecurityGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationSecurityGroupState<Missing, Missing, Missing>)

        member _.Zero(()) : ApplicationSecurityGroupState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ApplicationSecurityGroupState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_security_group#location-1">ApplicationSecurityGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: ApplicationSecurityGroupState<Missing, 'Name, 'ResourceGroupName>, value: string) : ApplicationSecurityGroupState<Present, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : ApplicationSecurityGroupState<Present, 'Name, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_security_group#name-1">ApplicationSecurityGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ApplicationSecurityGroupState<'Location, Missing, 'ResourceGroupName>, value: string) : ApplicationSecurityGroupState<'Location, Present, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ApplicationSecurityGroupState<'Location, Present, 'ResourceGroupName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_security_group#resource_group_name-1">ApplicationSecurityGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: ApplicationSecurityGroupState<'Location, 'Name, Missing>, value: string) : ApplicationSecurityGroupState<'Location, 'Name, Present> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : ApplicationSecurityGroupState<'Location, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_security_group#id-1">ApplicationSecurityGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName>, value: string) : ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_security_group#tags-1">ApplicationSecurityGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName>, value: seq<string * string>) : ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/application_security_group#timeouts-1">ApplicationSecurityGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName>, value: azurerm.ApplicationSecurityGroup.ApplicationSecurityGroupTimeouts) : ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ApplicationSecurityGroupState<'Location, 'Name, 'ResourceGroupName>

        member _.Run(state: ApplicationSecurityGroupState<Present, Present, Present>) : azurerm.ApplicationSecurityGroup.ApplicationSecurityGroup =
            let config = azurerm.ApplicationSecurityGroup.ApplicationSecurityGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.ApplicationSecurityGroup.ApplicationSecurityGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.applicationSecurityGroup: missing required arguments. Must call: location, name, resource_group_name.", 9999, IsError = true)>]
        member _.Run(_: ApplicationSecurityGroupState<_, _, _>) : azurerm.ApplicationSecurityGroup.ApplicationSecurityGroup =
            Unchecked.defaultof<azurerm.ApplicationSecurityGroup.ApplicationSecurityGroup>
