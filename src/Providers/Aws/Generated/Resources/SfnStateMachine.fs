namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type SfnStateMachineState<'Definition, 'RoleArn> = { assignments: ResizeArray<aws.SfnStateMachine.SfnStateMachineConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine">aws_sfn_state_machine</a>.
    /// </summary>
    type SfnStateMachineBuilder(logicalId: string) =
        member _.Yield(_: unit) : SfnStateMachineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SfnStateMachineState<Missing, Missing>)

        member _.Zero(()) : SfnStateMachineState<Missing, Missing> =
            ({ assignments = ResizeArray() } : SfnStateMachineState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#definition-1">SfnStateMachine#definition</a>.
        /// </summary>
        [<CustomOperation "definition">]
        member _.Definition(state: SfnStateMachineState<Missing, 'RoleArn>, value: string) : SfnStateMachineState<Present, 'RoleArn> =
            state.assignments.Add(fun config -> config.Definition <- value)
            ({ assignments = state.assignments } : SfnStateMachineState<Present, 'RoleArn>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#role_arn-1">SfnStateMachine#role_arn</a>.
        /// </summary>
        [<CustomOperation "role_arn">]
        member _.RoleArn(state: SfnStateMachineState<'Definition, Missing>, value: string) : SfnStateMachineState<'Definition, Present> =
            state.assignments.Add(fun config -> config.RoleArn <- value)
            ({ assignments = state.assignments } : SfnStateMachineState<'Definition, Present>)

        /// <summary>
        /// encryption_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#encryption_configuration-1">SfnStateMachine#encryption_configuration</a>
        /// </summary>
        [<CustomOperation "encryption_configuration">]
        member _.EncryptionConfiguration(state: SfnStateMachineState<'Definition, 'RoleArn>, value: aws.SfnStateMachine.SfnStateMachineEncryptionConfiguration) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.EncryptionConfiguration <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#id-1">SfnStateMachine#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: SfnStateMachineState<'Definition, 'RoleArn>, value: string) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// logging_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#logging_configuration-1">SfnStateMachine#logging_configuration</a>
        /// </summary>
        [<CustomOperation "logging_configuration">]
        member _.LoggingConfiguration(state: SfnStateMachineState<'Definition, 'RoleArn>, value: aws.SfnStateMachine.SfnStateMachineLoggingConfiguration) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.LoggingConfiguration <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#name-1">SfnStateMachine#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: SfnStateMachineState<'Definition, 'RoleArn>, value: string) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#name_prefix-1">SfnStateMachine#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: SfnStateMachineState<'Definition, 'RoleArn>, value: string) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#publish-1">SfnStateMachine#publish</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publish">]
        member _.Publish(state: SfnStateMachineState<'Definition, 'RoleArn>, value: bool) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.Publish <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#publish-1">SfnStateMachine#publish</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "publish">]
        member _.Publish(state: SfnStateMachineState<'Definition, 'RoleArn>, value: HashiCorp.Cdktf.IResolvable) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.Publish <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#tags-1">SfnStateMachine#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: SfnStateMachineState<'Definition, 'RoleArn>, value: seq<string * string>) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#tags_all-1">SfnStateMachine#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: SfnStateMachineState<'Definition, 'RoleArn>, value: seq<string * string>) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#timeouts-1">SfnStateMachine#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: SfnStateMachineState<'Definition, 'RoleArn>, value: aws.SfnStateMachine.SfnStateMachineTimeouts) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// tracing_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#tracing_configuration-1">SfnStateMachine#tracing_configuration</a>
        /// </summary>
        [<CustomOperation "tracing_configuration">]
        member _.TracingConfiguration(state: SfnStateMachineState<'Definition, 'RoleArn>, value: aws.SfnStateMachine.SfnStateMachineTracingConfiguration) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.TracingConfiguration <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/sfn_state_machine#type-1">SfnStateMachine#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: SfnStateMachineState<'Definition, 'RoleArn>, value: string) : SfnStateMachineState<'Definition, 'RoleArn> =
            state.assignments.Add(fun config -> config.Type <- value)
            state : SfnStateMachineState<'Definition, 'RoleArn>

        member _.Run(state: SfnStateMachineState<Present, Present>) : aws.SfnStateMachine.SfnStateMachine =
            let config = aws.SfnStateMachine.SfnStateMachineConfig()
            for setter in state.assignments do
                setter config
            aws.SfnStateMachine.SfnStateMachine(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.sfnStateMachine: missing required arguments. Must call: definition, role_arn.", 9999, IsError = true)>]
        member _.Run(_: SfnStateMachineState<_, _>) : aws.SfnStateMachine.SfnStateMachine =
            Unchecked.defaultof<aws.SfnStateMachine.SfnStateMachine>
