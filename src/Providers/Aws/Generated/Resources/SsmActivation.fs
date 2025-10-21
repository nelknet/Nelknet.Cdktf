namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SsmActivationState<'IamRole> = { assignments: ResizeArray<aws.SsmActivation.SsmActivationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_activation">aws_ssm_activation</a>.
    /// </summary>
    type SsmActivationBuilder(logicalId: string) =
        member _.Yield(_: unit) : SsmActivationState<Missing> =
            ({ assignments = ResizeArray() } : SsmActivationState<Missing>)

        member _.Zero(()) : SsmActivationState<Missing> =
            ({ assignments = ResizeArray() } : SsmActivationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_activation#iam_role-1">SsmActivation#iam_role</a>.
        /// </summary>
        [<CustomOperation "iam_role">]
        member _.IamRole(state: SsmActivationState<Missing>, value: string) : SsmActivationState<Present> =
            state.assignments.Add(fun config -> config.IamRole <- value)
            ({ assignments = state.assignments } : SsmActivationState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_activation#description-1">SsmActivation#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: SsmActivationState<'IamRole>, value: string) : SsmActivationState<'IamRole> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : SsmActivationState<'IamRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_activation#expiration_date-1">SsmActivation#expiration_date</a>.
        /// </summary>
        [<CustomOperation "expiration_date">]
        member _.ExpirationDate(state: SsmActivationState<'IamRole>, value: string) : SsmActivationState<'IamRole> =
            state.assignments.Add(fun config -> config.ExpirationDate <- value)
            state : SsmActivationState<'IamRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_activation#id-1">SsmActivation#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SsmActivationState<'IamRole>, value: string) : SsmActivationState<'IamRole> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SsmActivationState<'IamRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_activation#name-1">SsmActivation#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SsmActivationState<'IamRole>, value: string) : SsmActivationState<'IamRole> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SsmActivationState<'IamRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_activation#registration_limit-1">SsmActivation#registration_limit</a>.
        /// </summary>
        [<CustomOperation "registration_limit">]
        member _.RegistrationLimit(state: SsmActivationState<'IamRole>, value: double) : SsmActivationState<'IamRole> =
            state.assignments.Add(fun config -> config.RegistrationLimit <- value)
            state : SsmActivationState<'IamRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_activation#tags-1">SsmActivation#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SsmActivationState<'IamRole>, value: seq<string * string>) : SsmActivationState<'IamRole> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SsmActivationState<'IamRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/ssm_activation#tags_all-1">SsmActivation#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SsmActivationState<'IamRole>, value: seq<string * string>) : SsmActivationState<'IamRole> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SsmActivationState<'IamRole>

        member _.Run(state: SsmActivationState<Present>) : aws.SsmActivation.SsmActivation =
            let config = aws.SsmActivation.SsmActivationConfig()
            for setter in state.assignments do
                setter config
            aws.SsmActivation.SsmActivation(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.ssmActivation: missing required arguments. Must call: iam_role.", 9999, IsError = true)>]
        member _.Run(_: SsmActivationState<_>) : aws.SsmActivation.SsmActivation =
            Unchecked.defaultof<aws.SsmActivation.SsmActivation>
