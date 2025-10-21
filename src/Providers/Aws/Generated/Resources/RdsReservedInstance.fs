namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type RdsReservedInstanceState<'OfferingId> = { assignments: ResizeArray<aws.RdsReservedInstance.RdsReservedInstanceConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_reserved_instance">aws_rds_reserved_instance</a>.
    /// </summary>
    type RdsReservedInstanceBuilder(logicalId: string) =
        member _.Yield(_: unit) : RdsReservedInstanceState<Missing> =
            ({ assignments = ResizeArray() } : RdsReservedInstanceState<Missing>)

        member _.Zero(()) : RdsReservedInstanceState<Missing> =
            ({ assignments = ResizeArray() } : RdsReservedInstanceState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_reserved_instance#offering_id-1">RdsReservedInstance#offering_id</a>.
        /// </summary>
        [<CustomOperation "offering_id">]
        member _.OfferingId(state: RdsReservedInstanceState<Missing>, value: string) : RdsReservedInstanceState<Present> =
            state.assignments.Add(fun config -> config.OfferingId <- value)
            ({ assignments = state.assignments } : RdsReservedInstanceState<Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_reserved_instance#id-1">RdsReservedInstance#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: RdsReservedInstanceState<'OfferingId>, value: string) : RdsReservedInstanceState<'OfferingId> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : RdsReservedInstanceState<'OfferingId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_reserved_instance#instance_count-1">RdsReservedInstance#instance_count</a>.
        /// </summary>
        [<CustomOperation "instance_count">]
        member _.InstanceCount(state: RdsReservedInstanceState<'OfferingId>, value: double) : RdsReservedInstanceState<'OfferingId> =
            state.assignments.Add(fun config -> config.InstanceCount <- value)
            state : RdsReservedInstanceState<'OfferingId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_reserved_instance#reservation_id-1">RdsReservedInstance#reservation_id</a>.
        /// </summary>
        [<CustomOperation "reservation_id">]
        member _.ReservationId(state: RdsReservedInstanceState<'OfferingId>, value: string) : RdsReservedInstanceState<'OfferingId> =
            state.assignments.Add(fun config -> config.ReservationId <- value)
            state : RdsReservedInstanceState<'OfferingId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_reserved_instance#tags-1">RdsReservedInstance#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: RdsReservedInstanceState<'OfferingId>, value: seq<string * string>) : RdsReservedInstanceState<'OfferingId> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : RdsReservedInstanceState<'OfferingId>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_reserved_instance#tags_all-1">RdsReservedInstance#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: RdsReservedInstanceState<'OfferingId>, value: seq<string * string>) : RdsReservedInstanceState<'OfferingId> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : RdsReservedInstanceState<'OfferingId>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/rds_reserved_instance#timeouts-1">RdsReservedInstance#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: RdsReservedInstanceState<'OfferingId>, value: aws.RdsReservedInstance.RdsReservedInstanceTimeouts) : RdsReservedInstanceState<'OfferingId> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : RdsReservedInstanceState<'OfferingId>

        member _.Run(state: RdsReservedInstanceState<Present>) : aws.RdsReservedInstance.RdsReservedInstance =
            let config = aws.RdsReservedInstance.RdsReservedInstanceConfig()
            for setter in state.assignments do
                setter config
            aws.RdsReservedInstance.RdsReservedInstance(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.rdsReservedInstance: missing required arguments. Must call: offering_id.", 9999, IsError = true)>]
        member _.Run(_: RdsReservedInstanceState<_>) : aws.RdsReservedInstance.RdsReservedInstance =
            Unchecked.defaultof<aws.RdsReservedInstance.RdsReservedInstance>
