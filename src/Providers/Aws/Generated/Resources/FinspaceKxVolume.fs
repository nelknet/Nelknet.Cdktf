namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type> = { assignments: ResizeArray<aws.FinspaceKxVolume.FinspaceKxVolumeConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume">aws_finspace_kx_volume</a>.
    /// </summary>
    type FinspaceKxVolumeBuilder(logicalId: string) =
        member _.Yield(_: unit) : FinspaceKxVolumeState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxVolumeState<Missing, Missing, Missing, Missing, Missing>)

        member _.Zero(()) : FinspaceKxVolumeState<Missing, Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : FinspaceKxVolumeState<Missing, Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#availability_zones-1">FinspaceKxVolume#availability_zones</a>.
        /// </summary>
        [<CustomOperation "availability_zones">]
        member _.AvailabilityZones(state: FinspaceKxVolumeState<Missing, 'AzMode, 'EnvironmentId, 'Name, 'Type>, value: seq<string>) : FinspaceKxVolumeState<Present, 'AzMode, 'EnvironmentId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.AvailabilityZones <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : FinspaceKxVolumeState<Present, 'AzMode, 'EnvironmentId, 'Name, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#az_mode-1">FinspaceKxVolume#az_mode</a>.
        /// </summary>
        [<CustomOperation "az_mode">]
        member _.AzMode(state: FinspaceKxVolumeState<'AvailabilityZones, Missing, 'EnvironmentId, 'Name, 'Type>, value: string) : FinspaceKxVolumeState<'AvailabilityZones, Present, 'EnvironmentId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.AzMode <- value)
            ({ assignments = state.assignments } : FinspaceKxVolumeState<'AvailabilityZones, Present, 'EnvironmentId, 'Name, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#environment_id-1">FinspaceKxVolume#environment_id</a>.
        /// </summary>
        [<CustomOperation "environment_id">]
        member _.EnvironmentId(state: FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, Missing, 'Name, 'Type>, value: string) : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, Present, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.EnvironmentId <- value)
            ({ assignments = state.assignments } : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, Present, 'Name, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#name-1">FinspaceKxVolume#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, Missing, 'Type>, value: string) : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, Present, 'Type> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, Present, 'Type>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#type-1">FinspaceKxVolume#type</a>.
        /// </summary>
        [<CustomOperation "type">]
        member _.Type(state: FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, Missing>, value: string) : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, Present> =
            state.assignments.Add(fun config -> config.Type <- value)
            ({ assignments = state.assignments } : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#description-1">FinspaceKxVolume#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>, value: string) : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#id-1">FinspaceKxVolume#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>, value: string) : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>

        /// <summary>
        /// nas1_configuration block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#nas1_configuration-1">FinspaceKxVolume#nas1_configuration</a> Accepts: aws.IResolvable | aws.FinspaceKxVolume.FinspaceKxVolumeNas1Configuration[]
        /// </summary>
        [<CustomOperation "nas1_configuration">]
        member _.Nas1Configuration(state: FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>, value: HashiCorp.Cdktf.IResolvable) : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Nas1Configuration <- value)
            state : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#tags-1">FinspaceKxVolume#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>, value: seq<string * string>) : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#tags_all-1">FinspaceKxVolume#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>, value: seq<string * string>) : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/finspace_kx_volume#timeouts-1">FinspaceKxVolume#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>, value: aws.FinspaceKxVolume.FinspaceKxVolumeTimeouts) : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : FinspaceKxVolumeState<'AvailabilityZones, 'AzMode, 'EnvironmentId, 'Name, 'Type>

        member _.Run(state: FinspaceKxVolumeState<Present, Present, Present, Present, Present>) : aws.FinspaceKxVolume.FinspaceKxVolume =
            let config = aws.FinspaceKxVolume.FinspaceKxVolumeConfig()
            for setter in state.assignments do
                setter config
            aws.FinspaceKxVolume.FinspaceKxVolume(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.finspaceKxVolume: missing required arguments. Must call: availability_zones, az_mode, environment_id, name, type.", 9999, IsError = true)>]
        member _.Run(_: FinspaceKxVolumeState<_, _, _, _, _>) : aws.FinspaceKxVolume.FinspaceKxVolume =
            Unchecked.defaultof<aws.FinspaceKxVolume.FinspaceKxVolume>
