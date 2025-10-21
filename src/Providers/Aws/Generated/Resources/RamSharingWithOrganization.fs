namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RamSharingWithOrganizationState = { assignments: ResizeArray<aws.RamSharingWithOrganization.RamSharingWithOrganizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_sharing_with_organization">aws_ram_sharing_with_organization</a>.
    /// </summary>
    type RamSharingWithOrganizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : RamSharingWithOrganizationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : RamSharingWithOrganizationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ram_sharing_with_organization#id-1">RamSharingWithOrganization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RamSharingWithOrganizationState, value: string) : RamSharingWithOrganizationState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RamSharingWithOrganizationState

        member _.Run(state: RamSharingWithOrganizationState) : aws.RamSharingWithOrganization.RamSharingWithOrganization =
            let config = aws.RamSharingWithOrganization.RamSharingWithOrganizationConfig()
            for setter in state.assignments do
                setter config
            aws.RamSharingWithOrganization.RamSharingWithOrganization(StackContext.get (), logicalId, config)
