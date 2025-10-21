namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type KendraExperienceState<'IndexId, 'Name, 'RoleArn> = { assignments: ResizeArray<aws.KendraExperience.KendraExperienceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience">aws_kendra_experience</a>.
    /// </summary>
    type KendraExperienceBuilder(logicalId: string) =
        member _.Yield(_: unit) : KendraExperienceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraExperienceState<Missing, Missing, Missing>)

        member _.Zero(()) : KendraExperienceState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : KendraExperienceState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#index_id-1">KendraExperience#index_id</a>.
        /// </summary>
        [<CustomOperation "index_id">]
        member _.IndexId(state: KendraExperienceState<Missing, 'Name, 'RoleArn>, value: string) : KendraExperienceState<Present, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.IndexId <- value)
            ({ assignments = state.assignments } : KendraExperienceState<Present, 'Name, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#name-1">KendraExperience#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: KendraExperienceState<'IndexId, Missing, 'RoleArn>, value: string) : KendraExperienceState<'IndexId, Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : KendraExperienceState<'IndexId, Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#role_arn-1">KendraExperience#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: KendraExperienceState<'IndexId, 'Name, Missing>, value: string) : KendraExperienceState<'IndexId, 'Name, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : KendraExperienceState<'IndexId, 'Name, Present>)

        /// <summary>
        /// configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#configuration-1">KendraExperience#configuration</a>
        /// </summary>
        [<CustomOperation "configuration">]
        member _.Configuration(state: KendraExperienceState<'IndexId, 'Name, 'RoleArn>, value: aws.KendraExperience.KendraExperienceConfiguration) : KendraExperienceState<'IndexId, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Configuration <- value)
            state : KendraExperienceState<'IndexId, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#description-1">KendraExperience#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: KendraExperienceState<'IndexId, 'Name, 'RoleArn>, value: string) : KendraExperienceState<'IndexId, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : KendraExperienceState<'IndexId, 'Name, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#id-1">KendraExperience#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: KendraExperienceState<'IndexId, 'Name, 'RoleArn>, value: string) : KendraExperienceState<'IndexId, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : KendraExperienceState<'IndexId, 'Name, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kendra_experience#timeouts-1">KendraExperience#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: KendraExperienceState<'IndexId, 'Name, 'RoleArn>, value: aws.KendraExperience.KendraExperienceTimeouts) : KendraExperienceState<'IndexId, 'Name, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : KendraExperienceState<'IndexId, 'Name, 'RoleArn>

        member _.Run(state: KendraExperienceState<Present, Present, Present>) : aws.KendraExperience.KendraExperience =
            let config = aws.KendraExperience.KendraExperienceConfig()
            for setter in state.assignments do
                setter config
            aws.KendraExperience.KendraExperience(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kendraExperience: missing required arguments. Must call: index_id, name, role_arn.", 9999, IsError = true)>]
        member _.Run(_: KendraExperienceState<_, _, _>) : aws.KendraExperience.KendraExperience =
            Unchecked.defaultof<aws.KendraExperience.KendraExperience>
