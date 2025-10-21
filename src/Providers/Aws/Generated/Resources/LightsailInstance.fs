namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name> = { assignments: ResizeArray<aws.LightsailInstance.LightsailInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance">aws_lightsail_instance</a>.
    /// </summary>
    type LightsailInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : LightsailInstanceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailInstanceState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : LightsailInstanceState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : LightsailInstanceState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#availability_zone-1">LightsailInstance#availability_zone</a>.
        /// </summary>
        [<CustomOperation "availability_zone">]
        member _.AvailabilityZone(state: LightsailInstanceState<Missing, 'BlueprintId, 'BundleId, 'Name>, value: string) : LightsailInstanceState<Present, 'BlueprintId, 'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.AvailabilityZone <- value)
            ({ assignments = state.assignments } : LightsailInstanceState<Present, 'BlueprintId, 'BundleId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#blueprint_id-1">LightsailInstance#blueprint_id</a>.
        /// </summary>
        [<CustomOperation "blueprint_id">]
        member _.BlueprintId(state: LightsailInstanceState<'AvailabilityZone, Missing, 'BundleId, 'Name>, value: string) : LightsailInstanceState<'AvailabilityZone, Present, 'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.BlueprintId <- value)
            ({ assignments = state.assignments } : LightsailInstanceState<'AvailabilityZone, Present, 'BundleId, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#bundle_id-1">LightsailInstance#bundle_id</a>.
        /// </summary>
        [<CustomOperation "bundle_id">]
        member _.BundleId(state: LightsailInstanceState<'AvailabilityZone, 'BlueprintId, Missing, 'Name>, value: string) : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, Present, 'Name> =
            state.assignments.Add(fun config -> config.BundleId <- value)
            ({ assignments = state.assignments } : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#name-1">LightsailInstance#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, Missing>, value: string) : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, Present>)

        /// <summary>
        /// add_on block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#add_on-1">LightsailInstance#add_on</a>
        /// </summary>
        [<CustomOperation "add_on">]
        member _.AddOn(state: LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>, value: aws.LightsailInstance.LightsailInstanceAddOn) : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.AddOn <- value)
            state : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#id-1">LightsailInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>, value: string) : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#ip_address_type-1">LightsailInstance#ip_address_type</a>.
        /// </summary>
        [<CustomOperation "ip_address_type">]
        member _.IpAddressType(state: LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>, value: string) : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.IpAddressType <- value)
            state : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#key_pair_name-1">LightsailInstance#key_pair_name</a>.
        /// </summary>
        [<CustomOperation "key_pair_name">]
        member _.KeyPairName(state: LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>, value: string) : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.KeyPairName <- value)
            state : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#tags-1">LightsailInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>, value: seq<string * string>) : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#tags_all-1">LightsailInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>, value: seq<string * string>) : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/lightsail_instance#user_data-1">LightsailInstance#user_data</a>.
        /// </summary>
        [<CustomOperation "user_data">]
        member _.UserData(state: LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>, value: string) : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name> =
            state.assignments.Add(fun config -> config.UserData <- value)
            state : LightsailInstanceState<'AvailabilityZone, 'BlueprintId, 'BundleId, 'Name>

        member _.Run(state: LightsailInstanceState<Present, Present, Present, Present>) : aws.LightsailInstance.LightsailInstance =
            let config = aws.LightsailInstance.LightsailInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.LightsailInstance.LightsailInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.lightsailInstance: missing required arguments. Must call: availability_zone, blueprint_id, bundle_id, name.", 9999, IsError = true)>]
        member _.Run(_: LightsailInstanceState<_, _, _, _>) : aws.LightsailInstance.LightsailInstance =
            Unchecked.defaultof<aws.LightsailInstance.LightsailInstance>
