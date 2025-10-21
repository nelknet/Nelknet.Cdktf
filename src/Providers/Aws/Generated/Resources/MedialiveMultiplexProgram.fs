namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type MedialiveMultiplexProgramState<'MultiplexId, 'ProgramName> = { assignments: ResizeArray<aws.MedialiveMultiplexProgram.MedialiveMultiplexProgramConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program">aws_medialive_multiplex_program</a>.
    /// </summary>
    type MedialiveMultiplexProgramBuilder(logicalId: string) =
        member _.Yield(_: unit) : MedialiveMultiplexProgramState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MedialiveMultiplexProgramState<Missing, Missing>)

        member _.Zero(()) : MedialiveMultiplexProgramState<Missing, Missing> =
            ({ assignments = ResizeArray() } : MedialiveMultiplexProgramState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#multiplex_id-1">MedialiveMultiplexProgram#multiplex_id</a>.
        /// </summary>
        [<CustomOperation "multiplex_id">]
        member _.MultiplexId(state: MedialiveMultiplexProgramState<Missing, 'ProgramName>, value: string) : MedialiveMultiplexProgramState<Present, 'ProgramName> =
            state.assignments.Add(fun config -> config.MultiplexId <- value)
            ({ assignments = state.assignments } : MedialiveMultiplexProgramState<Present, 'ProgramName>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#program_name-1">MedialiveMultiplexProgram#program_name</a>.
        /// </summary>
        [<CustomOperation "program_name">]
        member _.ProgramName(state: MedialiveMultiplexProgramState<'MultiplexId, Missing>, value: string) : MedialiveMultiplexProgramState<'MultiplexId, Present> =
            state.assignments.Add(fun config -> config.ProgramName <- value)
            ({ assignments = state.assignments } : MedialiveMultiplexProgramState<'MultiplexId, Present>)

        /// <summary>
        /// multiplex_program_settings block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#multiplex_program_settings-1">MedialiveMultiplexProgram#multiplex_program_settings</a> Accepts: aws.IResolvable | aws.MedialiveMultiplexProgram.MedialiveMultiplexProgramMultiplexProgramSettings[]
        /// </summary>
        [<CustomOperation "multiplex_program_settings">]
        member _.MultiplexProgramSettings(state: MedialiveMultiplexProgramState<'MultiplexId, 'ProgramName>, value: HashiCorp.Cdktf.IResolvable) : MedialiveMultiplexProgramState<'MultiplexId, 'ProgramName> =
            state.assignments.Add(fun config -> config.MultiplexProgramSettings <- value)
            state : MedialiveMultiplexProgramState<'MultiplexId, 'ProgramName>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/medialive_multiplex_program#timeouts-1">MedialiveMultiplexProgram#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: MedialiveMultiplexProgramState<'MultiplexId, 'ProgramName>, value: aws.MedialiveMultiplexProgram.MedialiveMultiplexProgramTimeouts) : MedialiveMultiplexProgramState<'MultiplexId, 'ProgramName> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : MedialiveMultiplexProgramState<'MultiplexId, 'ProgramName>

        member _.Run(state: MedialiveMultiplexProgramState<Present, Present>) : aws.MedialiveMultiplexProgram.MedialiveMultiplexProgram =
            let config = aws.MedialiveMultiplexProgram.MedialiveMultiplexProgramConfig()
            for setter in state.assignments do
                setter config
            aws.MedialiveMultiplexProgram.MedialiveMultiplexProgram(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.medialiveMultiplexProgram: missing required arguments. Must call: multiplex_id, program_name.", 9999, IsError = true)>]
        member _.Run(_: MedialiveMultiplexProgramState<_, _>) : aws.MedialiveMultiplexProgram.MedialiveMultiplexProgram =
            Unchecked.defaultof<aws.MedialiveMultiplexProgram.MedialiveMultiplexProgram>
