namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb> = { assignments: ResizeArray<aws.LightsailDisk.LightsailDiskConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk">aws_lightsail_disk</a>.
    /// </summary>
    type LightsailDiskBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailDiskState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDiskState<Missing, Missing, Missing>)

        member _.Zero(()) : LightsailDiskState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailDiskState<Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk#availability_zone-1">LightsailDisk#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: LightsailDiskState<Missing, 'Name, 'SizeInGb>, value: string) : LightsailDiskState<Present, 'Name, 'SizeInGb> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            ({ assignments = state.assignments } : LightsailDiskState<Present, 'Name, 'SizeInGb>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk#name-1">LightsailDisk#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailDiskState<'AvailabilityZone, Missing, 'SizeInGb>, value: string) : LightsailDiskState<'AvailabilityZone, Present, 'SizeInGb> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailDiskState<'AvailabilityZone, Present, 'SizeInGb>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk#size_in_gb-1">LightsailDisk#size_in_gb</a>.
        /// </summary>
        [<CustomOperation "size_in_gb">]
        member _.SizeInGb(state: LightsailDiskState<'AvailabilityZone, 'Name, Missing>, value: double) : LightsailDiskState<'AvailabilityZone, 'Name, Present> =
            state.assignments.Add(fun config -> config.SizeInGb <- value)
            ({ assignments = state.assignments } : LightsailDiskState<'AvailabilityZone, 'Name, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk#id-1">LightsailDisk#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb>, value: string) : LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk#tags-1">LightsailDisk#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb>, value: seq<string * string>) : LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_disk#tags_all-1">LightsailDisk#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb>, value: seq<string * string>) : LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LightsailDiskState<'AvailabilityZone, 'Name, 'SizeInGb>

        member _.Run(state: LightsailDiskState<Present, Present, Present>) : aws.LightsailDisk.LightsailDisk =
            let config = aws.LightsailDisk.LightsailDiskConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailDisk.LightsailDisk(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailDisk: missing required arguments. Must call: availability_zone, name, size_in_gb.", 9999, IsError = true)>]
        member _.Run(_: LightsailDiskState<_, _, _>) : aws.LightsailDisk.LightsailDisk =
            Unchecked.defaultof<aws.LightsailDisk.LightsailDisk>
