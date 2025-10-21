namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type IamOrganizationsFeaturesState<'EnabledFeatures> = { assignments: ResizeArray<aws.IamOrganizationsFeatures.IamOrganizationsFeaturesConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_organizations_features">aws_iam_organizations_features</a>.
    /// </summary>
    type IamOrganizationsFeaturesBuilder(logicalId: string) =
        member _.Yield(_: unit) : IamOrganizationsFeaturesState<Missing> =
            ({ assignments = ResizeArray() } : IamOrganizationsFeaturesState<Missing>)

        member _.Zero(()) : IamOrganizationsFeaturesState<Missing> =
            ({ assignments = ResizeArray() } : IamOrganizationsFeaturesState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/iam_organizations_features#enabled_features-1">IamOrganizationsFeatures#enabled_features</a>.
        /// </summary>
        [<CustomOperation "enabled_features">]
        member _.EnabledFeatures(state: IamOrganizationsFeaturesState<Missing>, value: seq<string>) : IamOrganizationsFeaturesState<Present> =
            state.assignments.Add(fun config -> config.EnabledFeatures <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : IamOrganizationsFeaturesState<Present>)

        member _.Run(state: IamOrganizationsFeaturesState<Present>) : aws.IamOrganizationsFeatures.IamOrganizationsFeatures =
            let config = aws.IamOrganizationsFeatures.IamOrganizationsFeaturesConfig()
            for setter in state.assignments do
                setter config
            aws.IamOrganizationsFeatures.IamOrganizationsFeatures(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.iamOrganizationsFeatures: missing required arguments. Must call: enabled_features.", 9999, IsError = true)>]
        member _.Run(_: IamOrganizationsFeaturesState<_>) : aws.IamOrganizationsFeatures.IamOrganizationsFeatures =
            Unchecked.defaultof<aws.IamOrganizationsFeatures.IamOrganizationsFeatures>
