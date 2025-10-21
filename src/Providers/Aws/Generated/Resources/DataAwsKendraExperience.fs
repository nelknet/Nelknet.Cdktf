namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type DataAwsKendraExperienceState<'ExperienceId, 'IndexId> = { assignments: ResizeArray<aws.DataAwsKendraExperience.DataAwsKendraExperienceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_experience">aws_kendra_experience</a>.
    /// </summary>
    type DataAwsKendraExperienceBuilder(logicalId: string) =
        member _.Yield(_: unit) : DataAwsKendraExperienceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraExperienceState<Missing, Missing>)

        member _.Zero(()) : DataAwsKendraExperienceState<Missing, Missing> =
            ({ assignments = ResizeArray() } : DataAwsKendraExperienceState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_experience#experience_id-1">DataAwsKendraExperience#experience_id</a>.
        /// </summary>
        [<CustomOperation "experience_id">]
        member _.ExperienceId(state: DataAwsKendraExperienceState<Missing, 'IndexId>, value: string) : DataAwsKendraExperienceState<Present, 'IndexId> =
            state.assignments.Add(fun config -> config.ExperienceId <- value)
            ({ assignments = state.assignments } : DataAwsKendraExperienceState<Present, 'IndexId>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_experience#index_id-1">DataAwsKendraExperience#index_id</a>.
        /// </summary>
        [<CustomOperation "index_id">]
        member _.IndexId(state: DataAwsKendraExperienceState<'ExperienceId, Missing>, value: string) : DataAwsKendraExperienceState<'ExperienceId, Present> =
            state.assignments.Add(fun config -> config.IndexId <- value)
            ({ assignments = state.assignments } : DataAwsKendraExperienceState<'ExperienceId, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/data-sources/kendra_experience#id-1">DataAwsKendraExperience#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: DataAwsKendraExperienceState<'ExperienceId, 'IndexId>, value: string) : DataAwsKendraExperienceState<'ExperienceId, 'IndexId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : DataAwsKendraExperienceState<'ExperienceId, 'IndexId>

        member _.Run(state: DataAwsKendraExperienceState<Present, Present>) : aws.DataAwsKendraExperience.DataAwsKendraExperience =
            let config = aws.DataAwsKendraExperience.DataAwsKendraExperienceConfig()
            for setter in state.assignments do
                setter config
            aws.DataAwsKendraExperience.DataAwsKendraExperience(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.dataAwsKendraExperience: missing required arguments. Must call: experience_id, index_id.", 9999, IsError = true)>]
        member _.Run(_: DataAwsKendraExperienceState<_, _>) : aws.DataAwsKendraExperience.DataAwsKendraExperience =
            Unchecked.defaultof<aws.DataAwsKendraExperience.DataAwsKendraExperience>
