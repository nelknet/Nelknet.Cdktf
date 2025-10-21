namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> = { assignments: ResizeArray<aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application">aws_kinesisanalyticsv2_application</a>.
    /// </summary>
    type Kinesisanalyticsv2ApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : Kinesisanalyticsv2ApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Kinesisanalyticsv2ApplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : Kinesisanalyticsv2ApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Kinesisanalyticsv2ApplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#name-1">Kinesisanalyticsv2Application#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: Kinesisanalyticsv2ApplicationState<Missing, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: string) : Kinesisanalyticsv2ApplicationState<Present, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : Kinesisanalyticsv2ApplicationState<Present, 'RuntimeEnvironment, 'ServiceExecutionRole>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#runtime_environment-1">Kinesisanalyticsv2Application#runtime_environment</a>.
        /// </summary>
        [<CustomOperation "runtime_environment">]
        member _.RuntimeEnvironment(state: Kinesisanalyticsv2ApplicationState<'Name, Missing, 'ServiceExecutionRole>, value: string) : Kinesisanalyticsv2ApplicationState<'Name, Present, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.RuntimeEnvironment <- value)
            ({ assignments = state.assignments } : Kinesisanalyticsv2ApplicationState<'Name, Present, 'ServiceExecutionRole>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#service_execution_role-1">Kinesisanalyticsv2Application#service_execution_role</a>.
        /// </summary>
        [<CustomOperation "service_execution_role">]
        member _.ServiceExecutionRole(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, Missing>, value: string) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, Present> =
            state.assignments.Add(fun config -> config.ServiceExecutionRole <- value)
            ({ assignments = state.assignments } : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, Present>)

        /// <summary>
        /// application_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#application_configuration-1">Kinesisanalyticsv2Application#application_configuration</a>
        /// </summary>
        [<CustomOperation "application_configuration">]
        member _.ApplicationConfiguration(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationApplicationConfiguration) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.ApplicationConfiguration <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#application_mode-1">Kinesisanalyticsv2Application#application_mode</a>.
        /// </summary>
        [<CustomOperation "application_mode">]
        member _.ApplicationMode(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: string) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.ApplicationMode <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// cloudwatch_logging_options block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#cloudwatch_logging_options-1">Kinesisanalyticsv2Application#cloudwatch_logging_options</a>
        /// </summary>
        [<CustomOperation "cloudwatch_logging_options">]
        member _.CloudwatchLoggingOptions(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationCloudwatchLoggingOptions) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.CloudwatchLoggingOptions <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#description-1">Kinesisanalyticsv2Application#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: string) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#force_stop-1">Kinesisanalyticsv2Application#force_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_stop">]
        member _.ForceStop(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: bool) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.ForceStop <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#force_stop-1">Kinesisanalyticsv2Application#force_stop</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_stop">]
        member _.ForceStop(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: HashiCorp.Cdktf.IResolvable) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.ForceStop <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#id-1">Kinesisanalyticsv2Application#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: string) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#start_application-1">Kinesisanalyticsv2Application#start_application</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_application">]
        member _.StartApplication(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: bool) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.StartApplication <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#start_application-1">Kinesisanalyticsv2Application#start_application</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "start_application">]
        member _.StartApplication(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: HashiCorp.Cdktf.IResolvable) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.StartApplication <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#tags-1">Kinesisanalyticsv2Application#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: seq<string * string>) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#tags_all-1">Kinesisanalyticsv2Application#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: seq<string * string>) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/kinesisanalyticsv2_application#timeouts-1">Kinesisanalyticsv2Application#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>, value: aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationTimeouts) : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Kinesisanalyticsv2ApplicationState<'Name, 'RuntimeEnvironment, 'ServiceExecutionRole>

        member _.Run(state: Kinesisanalyticsv2ApplicationState<Present, Present, Present>) : aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2Application =
            let config = aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2ApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2Application(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.kinesisanalyticsv2Application: missing required arguments. Must call: name, runtime_environment, service_execution_role.", 9999, IsError = true)>]
        member _.Run(_: Kinesisanalyticsv2ApplicationState<_, _, _>) : aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2Application =
            Unchecked.defaultof<aws.Kinesisanalyticsv2Application.Kinesisanalyticsv2Application>
