namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type OrganizationsOrganizationState = { assignments: ResizeArray<aws.OrganizationsOrganization.OrganizationsOrganizationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organization">aws_organizations_organization</a>.
    /// </summary>
    type OrganizationsOrganizationBuilder(logicalId: string) =
        member _.Yield(_: unit) : OrganizationsOrganizationState =
            { assignments = ResizeArray() }

        member _.Zero(()) : OrganizationsOrganizationState =
            { assignments = ResizeArray() }

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organization#aws_service_access_principals-1">OrganizationsOrganization#aws_service_access_principals</a>.
        /// </summary>
        [<CustomOperation "aws_service_access_principals">]
        member _.AwsServiceAccessPrincipals(state: OrganizationsOrganizationState, value: seq<string>) : OrganizationsOrganizationState =
            state.assignments.Add(fun config -> config.AwsServiceAccessPrincipals <- (value |> Seq.toArray))
            state : OrganizationsOrganizationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organization#enabled_policy_types-1">OrganizationsOrganization#enabled_policy_types</a>.
        /// </summary>
        [<CustomOperation "enabled_policy_types">]
        member _.EnabledPolicyTypes(state: OrganizationsOrganizationState, value: seq<string>) : OrganizationsOrganizationState =
            state.assignments.Add(fun config -> config.EnabledPolicyTypes <- (value |> Seq.toArray))
            state : OrganizationsOrganizationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organization#feature_set-1">OrganizationsOrganization#feature_set</a>.
        /// </summary>
        [<CustomOperation "feature_set">]
        member _.FeatureSet(state: OrganizationsOrganizationState, value: string) : OrganizationsOrganizationState =
            state.assignments.Add(fun config -> config.FeatureSet <- value)
            state : OrganizationsOrganizationState

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/organizations_organization#id-1">OrganizationsOrganization#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: OrganizationsOrganizationState, value: string) : OrganizationsOrganizationState =
            state.assignments.Add(fun config -> config.Id <- value)
            state : OrganizationsOrganizationState

        member _.Run(state: OrganizationsOrganizationState) : aws.OrganizationsOrganization.OrganizationsOrganization =
            let config = aws.OrganizationsOrganization.OrganizationsOrganizationConfig()
            for setter in state.assignments do
                setter config
            aws.OrganizationsOrganization.OrganizationsOrganization(StackContext.get (), logicalId, config)
