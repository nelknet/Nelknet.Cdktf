namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> = { assignments: ResizeArray<aws.EmrserverlessApplication.EmrserverlessApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application">aws_emrserverless_application</a>.
    /// </summary>
    type EmrserverlessApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : EmrserverlessApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrserverlessApplicationState<Missing, Missing, Missing>)

        member _.Zero(()) : EmrserverlessApplicationState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : EmrserverlessApplicationState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#name-1">EmrserverlessApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: EmrserverlessApplicationState<Missing, 'ReleaseLabel, 'Type>, value: string) : EmrserverlessApplicationState<Present, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : EmrserverlessApplicationState<Present, 'ReleaseLabel, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#release_label-1">EmrserverlessApplication#release_label</a>.
        /// </summary>
        [<CustomOperation "release_label">]
        member _.ReleaseLabel(state: EmrserverlessApplicationState<'Name, Missing, 'Type>, value: string) : EmrserverlessApplicationState<'Name, Present, 'Type> =
            state.assignments.Add(fun config -> config.ReleaseLabel <- value)
            ({ assignments = state.assignments } : EmrserverlessApplicationState<'Name, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#type-1">EmrserverlessApplication#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, Missing>, value: string) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : EmrserverlessApplicationState<'Name, 'ReleaseLabel, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#architecture-1">EmrserverlessApplication#architecture</a>.
        /// </summary>
        [<CustomOperation "architecture">]
        member _.Architecture(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: string) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.Architecture <- value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// auto_start_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#auto_start_configuration-1">EmrserverlessApplication#auto_start_configuration</a>
        /// </summary>
        [<CustomOperation "auto_start_configuration">]
        member _.AutoStartConfiguration(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: aws.EmrserverlessApplication.EmrserverlessApplicationAutoStartConfiguration) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.AutoStartConfiguration <- value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// auto_stop_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#auto_stop_configuration-1">EmrserverlessApplication#auto_stop_configuration</a>
        /// </summary>
        [<CustomOperation "auto_stop_configuration">]
        member _.AutoStopConfiguration(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: aws.EmrserverlessApplication.EmrserverlessApplicationAutoStopConfiguration) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.AutoStopConfiguration <- value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#id-1">EmrserverlessApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: string) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// image_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#image_configuration-1">EmrserverlessApplication#image_configuration</a>
        /// </summary>
        [<CustomOperation "image_configuration">]
        member _.ImageConfiguration(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: aws.EmrserverlessApplication.EmrserverlessApplicationImageConfiguration) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.ImageConfiguration <- value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// initial_capacity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#initial_capacity-1">EmrserverlessApplication#initial_capacity</a> Accepts: aws.IResolvable | aws.EmrserverlessApplication.EmrserverlessApplicationInitialCapacity[]
        /// </summary>
        [<CustomOperation "initial_capacity">]
        member _.InitialCapacity(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: HashiCorp.Cdktf.IResolvable) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.InitialCapacity <- value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// interactive_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#interactive_configuration-1">EmrserverlessApplication#interactive_configuration</a>
        /// </summary>
        [<CustomOperation "interactive_configuration">]
        member _.InteractiveConfiguration(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: aws.EmrserverlessApplication.EmrserverlessApplicationInteractiveConfiguration) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.InteractiveConfiguration <- value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// maximum_capacity block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#maximum_capacity-1">EmrserverlessApplication#maximum_capacity</a>
        /// </summary>
        [<CustomOperation "maximum_capacity">]
        member _.MaximumCapacity(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: aws.EmrserverlessApplication.EmrserverlessApplicationMaximumCapacity) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.MaximumCapacity <- value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// network_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#network_configuration-1">EmrserverlessApplication#network_configuration</a>
        /// </summary>
        [<CustomOperation "network_configuration">]
        member _.NetworkConfiguration(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: aws.EmrserverlessApplication.EmrserverlessApplicationNetworkConfiguration) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.NetworkConfiguration <- value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#tags-1">EmrserverlessApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: seq<string * string>) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/emrserverless_application#tags_all-1">EmrserverlessApplication#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>, value: seq<string * string>) : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : EmrserverlessApplicationState<'Name, 'ReleaseLabel, 'Type>

        member _.Run(state: EmrserverlessApplicationState<Present, Present, Present>) : aws.EmrserverlessApplication.EmrserverlessApplication =
            let config = aws.EmrserverlessApplication.EmrserverlessApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.EmrserverlessApplication.EmrserverlessApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.emrserverlessApplication: missing required arguments. Must call: name, release_label, type.", 9999, IsError = true)>]
        member _.Run(_: EmrserverlessApplicationState<_, _, _>) : aws.EmrserverlessApplication.EmrserverlessApplication =
            Unchecked.defaultof<aws.EmrserverlessApplication.EmrserverlessApplication>
