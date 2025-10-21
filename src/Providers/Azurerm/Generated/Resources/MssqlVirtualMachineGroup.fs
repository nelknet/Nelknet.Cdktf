namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile> = { assignments: ResizeArray<azurerm.MssqlVirtualMachineGroup.MssqlVirtualMachineGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group">azurerm_mssql_virtual_machine_group</a>.
    /// </summary>
    type MssqlVirtualMachineGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : MssqlVirtualMachineGroupState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlVirtualMachineGroupState<Missing, Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : MssqlVirtualMachineGroupState<Missing, Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : MssqlVirtualMachineGroupState<Missing, Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#location-1">MssqlVirtualMachineGroup#location</a>.
        /// </summary>
        [<CustomOperation "location">]
        member _.Location(state: MssqlVirtualMachineGroupState<Missing, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>, value: string) : MssqlVirtualMachineGroupState<Present, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile> =
            state.assignments.Add(fun config -> config.Location <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineGroupState<Present, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#name-1">MssqlVirtualMachineGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: MssqlVirtualMachineGroupState<'Location, Missing, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>, value: string) : MssqlVirtualMachineGroupState<'Location, Present, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineGroupState<'Location, Present, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#resource_group_name-1">MssqlVirtualMachineGroup#resource_group_name</a>.
        /// </summary>
        [<CustomOperation "resource_group_name">]
        member _.ResourceGroupName(state: MssqlVirtualMachineGroupState<'Location, 'Name, Missing, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>, value: string) : MssqlVirtualMachineGroupState<'Location, 'Name, Present, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile> =
            state.assignments.Add(fun config -> config.ResourceGroupName <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineGroupState<'Location, 'Name, Present, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#sql_image_offer-1">MssqlVirtualMachineGroup#sql_image_offer</a>.
        /// </summary>
        [<CustomOperation "sql_image_offer">]
        member _.SqlImageOffer(state: MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, Missing, 'SqlImageSku, 'WsfcDomainProfile>, value: string) : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, Present, 'SqlImageSku, 'WsfcDomainProfile> =
            state.assignments.Add(fun config -> config.SqlImageOffer <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, Present, 'SqlImageSku, 'WsfcDomainProfile>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#sql_image_sku-1">MssqlVirtualMachineGroup#sql_image_sku</a>.
        /// </summary>
        [<CustomOperation "sql_image_sku">]
        member _.SqlImageSku(state: MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, Missing, 'WsfcDomainProfile>, value: string) : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, Present, 'WsfcDomainProfile> =
            state.assignments.Add(fun config -> config.SqlImageSku <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, Present, 'WsfcDomainProfile>)

        /// <summary>
        /// wsfc_domain_profile block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#wsfc_domain_profile-1">MssqlVirtualMachineGroup#wsfc_domain_profile</a>
        /// </summary>
        [<CustomOperation "wsfc_domain_profile">]
        member _.WsfcDomainProfile(state: MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, Missing>, value: azurerm.MssqlVirtualMachineGroup.MssqlVirtualMachineGroupWsfcDomainProfile) : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, Present> =
            state.assignments.Add(fun config -> config.WsfcDomainProfile <- value)
            ({ assignments = state.assignments } : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#id-1">MssqlVirtualMachineGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>, value: string) : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#tags-1">MssqlVirtualMachineGroup#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>, value: seq<string * string>) : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/azurerm/4.1.0/docs/resources/mssql_virtual_machine_group#timeouts-1">MssqlVirtualMachineGroup#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>, value: azurerm.MssqlVirtualMachineGroup.MssqlVirtualMachineGroupTimeouts) : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MssqlVirtualMachineGroupState<'Location, 'Name, 'ResourceGroupName, 'SqlImageOffer, 'SqlImageSku, 'WsfcDomainProfile>

        member _.Run(state: MssqlVirtualMachineGroupState<Present, Present, Present, Present, Present, Present>) : azurerm.MssqlVirtualMachineGroup.MssqlVirtualMachineGroup =
            let config = azurerm.MssqlVirtualMachineGroup.MssqlVirtualMachineGroupConfig()
            for setter in state.assignments do
                setter config
            azurerm.MssqlVirtualMachineGroup.MssqlVirtualMachineGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Azurerm.mssqlVirtualMachineGroup: missing required arguments. Must call: location, name, resource_group_name, sql_image_offer, sql_image_sku, wsfc_domain_profile.", 9999, IsError = true)>]
        member _.Run(_: MssqlVirtualMachineGroupState<_, _, _, _, _, _>) : azurerm.MssqlVirtualMachineGroup.MssqlVirtualMachineGroup =
            Unchecked.defaultof<azurerm.MssqlVirtualMachineGroup.MssqlVirtualMachineGroup>
