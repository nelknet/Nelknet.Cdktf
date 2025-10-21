namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElbState<'Listener> = { assignments: ResizeArray<aws.Elb.ElbConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb">aws_elb</a>.
    /// </summary>
    type ElbBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElbState<Missing> =
            ({ assignments = ResizeArray() } : ElbState<Missing>)

        member _.Zero(()) : ElbState<Missing> =
            ({ assignments = ResizeArray() } : ElbState<Missing>)

        /// <summary>
        /// listener block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#listener-1">Elb#listener</a> Accepts: aws.IResolvable | aws.Elb.ElbListener[]
        /// </summary>
        [<CustomOperation "listener">]
        member _.Listener(state: ElbState<Missing>, value: HashiCorp.Cdktf.IResolvable) : ElbState<Present> =
            state.assignments.Add(fun config -> config.Listener <- value)
            ({ assignments = state.assignments } : ElbState<Present>)

        /// <summary>
        /// access_logs block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#access_logs-1">Elb#access_logs</a>
        /// </summary>
        [<CustomOperation "access_logs">]
        member _.AccessLogs(state: ElbState<'Listener>, value: aws.Elb.ElbAccessLogs) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.AccessLogs <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#availability_zones-1">Elb#availability_zones</a>.
        /// </summary>
        [<CustomOperation "availability_zones">]
        member _.AvailabilityZones(state: ElbState<'Listener>, value: seq<string>) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.AvailabilityZones <- (value |> Seq.toArray))
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#connection_draining-1">Elb#connection_draining</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "connection_draining">]
        member _.ConnectionDraining(state: ElbState<'Listener>, value: bool) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.ConnectionDraining <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#connection_draining-1">Elb#connection_draining</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "connection_draining">]
        member _.ConnectionDraining(state: ElbState<'Listener>, value: HashiCorp.Cdktf.IResolvable) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.ConnectionDraining <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#connection_draining_timeout-1">Elb#connection_draining_timeout</a>.
        /// </summary>
        [<CustomOperation "connection_draining_timeout">]
        member _.ConnectionDrainingTimeout(state: ElbState<'Listener>, value: double) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.ConnectionDrainingTimeout <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#cross_zone_load_balancing-1">Elb#cross_zone_load_balancing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cross_zone_load_balancing">]
        member _.CrossZoneLoadBalancing(state: ElbState<'Listener>, value: bool) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.CrossZoneLoadBalancing <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#cross_zone_load_balancing-1">Elb#cross_zone_load_balancing</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "cross_zone_load_balancing">]
        member _.CrossZoneLoadBalancing(state: ElbState<'Listener>, value: HashiCorp.Cdktf.IResolvable) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.CrossZoneLoadBalancing <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#desync_mitigation_mode-1">Elb#desync_mitigation_mode</a>.
        /// </summary>
        [<CustomOperation "desync_mitigation_mode">]
        member _.DesyncMitigationMode(state: ElbState<'Listener>, value: string) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.DesyncMitigationMode <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// health_check block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#health_check-1">Elb#health_check</a>
        /// </summary>
        [<CustomOperation "health_check">]
        member _.HealthCheck(state: ElbState<'Listener>, value: aws.Elb.ElbHealthCheck) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.HealthCheck <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#id-1">Elb#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElbState<'Listener>, value: string) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#idle_timeout-1">Elb#idle_timeout</a>.
        /// </summary>
        [<CustomOperation "idle_timeout">]
        member _.IdleTimeout(state: ElbState<'Listener>, value: double) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.IdleTimeout <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#instances-1">Elb#instances</a>.
        /// </summary>
        [<CustomOperation "instances">]
        member _.Instances(state: ElbState<'Listener>, value: seq<string>) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.Instances <- (value |> Seq.toArray))
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#internal-1">Elb#internal</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "internal">]
        member _.Internal(state: ElbState<'Listener>, value: bool) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.Internal <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#internal-1">Elb#internal</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "internal">]
        member _.Internal(state: ElbState<'Listener>, value: HashiCorp.Cdktf.IResolvable) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.Internal <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#name-1">Elb#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElbState<'Listener>, value: string) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.Name <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#name_prefix-1">Elb#name_prefix</a>.
        /// </summary>
        [<CustomOperation "name_prefix">]
        member _.NamePrefix(state: ElbState<'Listener>, value: string) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.NamePrefix <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#security_groups-1">Elb#security_groups</a>.
        /// </summary>
        [<CustomOperation "security_groups">]
        member _.SecurityGroups(state: ElbState<'Listener>, value: seq<string>) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.SecurityGroups <- (value |> Seq.toArray))
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#source_security_group-1">Elb#source_security_group</a>.
        /// </summary>
        [<CustomOperation "source_security_group">]
        member _.SourceSecurityGroup(state: ElbState<'Listener>, value: string) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.SourceSecurityGroup <- value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#subnets-1">Elb#subnets</a>.
        /// </summary>
        [<CustomOperation "subnets">]
        member _.Subnets(state: ElbState<'Listener>, value: seq<string>) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.Subnets <- (value |> Seq.toArray))
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#tags-1">Elb#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElbState<'Listener>, value: seq<string * string>) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElbState<'Listener>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#tags_all-1">Elb#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElbState<'Listener>, value: seq<string * string>) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElbState<'Listener>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elb#timeouts-1">Elb#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: ElbState<'Listener>, value: aws.Elb.ElbTimeouts) : ElbState<'Listener> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : ElbState<'Listener>

        member _.Run(state: ElbState<Present>) : aws.Elb.Elb =
            let config = aws.Elb.ElbConfig()
            for setter in state.assignments do
                setter config
            aws.Elb.Elb(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elb: missing required arguments. Must call: listener.", 9999, IsError = true)>]
        member _.Run(_: ElbState<_>) : aws.Elb.Elb =
            Unchecked.defaultof<aws.Elb.Elb>
