namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType> = { assignments: ResizeArray<aws.Route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set">aws_route53recoveryreadiness_resource_set</a>.
    /// </summary>
    type Route53RecoveryreadinessResourceSetBuilder(logicalId: string) =
        member _.Yield(_: unit) : Route53RecoveryreadinessResourceSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoveryreadinessResourceSetState<Missing, Missing, Missing>)

        member _.Zero(()) : Route53RecoveryreadinessResourceSetState<Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : Route53RecoveryreadinessResourceSetState<Missing, Missing, Missing>)

        /// <summary>
        /// resources block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#resources-1">Route53RecoveryreadinessResourceSet#resources</a> Accepts: aws.IResolvable | aws.Route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetResources[]
        /// </summary>
        [<CustomOperation "resources">]
        member _.Resources(state: Route53RecoveryreadinessResourceSetState<Missing, 'ResourceSetName, 'ResourceSetType>, value: HashiCorp.Cdktf.IResolvable) : Route53RecoveryreadinessResourceSetState<Present, 'ResourceSetName, 'ResourceSetType> =
            state.assignments.Add(fun config -> config.Resources <- value)
            ({ assignments = state.assignments } : Route53RecoveryreadinessResourceSetState<Present, 'ResourceSetName, 'ResourceSetType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#resource_set_name-1">Route53RecoveryreadinessResourceSet#resource_set_name</a>.
        /// </summary>
        [<CustomOperation "resource_set_name">]
        member _.ResourceSetName(state: Route53RecoveryreadinessResourceSetState<'Resources, Missing, 'ResourceSetType>, value: string) : Route53RecoveryreadinessResourceSetState<'Resources, Present, 'ResourceSetType> =
            state.assignments.Add(fun config -> config.ResourceSetName <- value)
            ({ assignments = state.assignments } : Route53RecoveryreadinessResourceSetState<'Resources, Present, 'ResourceSetType>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#resource_set_type-1">Route53RecoveryreadinessResourceSet#resource_set_type</a>.
        /// </summary>
        [<CustomOperation "resource_set_type">]
        member _.ResourceSetType(state: Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, Missing>, value: string) : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, Present> =
            state.assignments.Add(fun config -> config.ResourceSetType <- value)
            ({ assignments = state.assignments } : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#id-1">Route53RecoveryreadinessResourceSet#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType>, value: string) : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#tags-1">Route53RecoveryreadinessResourceSet#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType>, value: seq<string * string>) : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#tags_all-1">Route53RecoveryreadinessResourceSet#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType>, value: seq<string * string>) : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType>

        /// <summary>
        /// timeouts block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/route53recoveryreadiness_resource_set#timeouts-1">Route53RecoveryreadinessResourceSet#timeouts</a>
        /// </summary>
        [<CustomOperation "timeouts">]
        member _.Timeouts(state: Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType>, value: aws.Route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetTimeouts) : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType> =
            state.assignments.Add(fun config -> config.Timeouts <- value)
            state : Route53RecoveryreadinessResourceSetState<'Resources, 'ResourceSetName, 'ResourceSetType>

        member _.Run(state: Route53RecoveryreadinessResourceSetState<Present, Present, Present>) : aws.Route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSet =
            let config = aws.Route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSetConfig()
            for setter in state.assignments do
                setter config
            aws.Route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSet(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.route53RecoveryreadinessResourceSet: missing required arguments. Must call: resources, resource_set_name, resource_set_type.", 9999, IsError = true)>]
        member _.Run(_: Route53RecoveryreadinessResourceSetState<_, _, _>) : aws.Route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSet =
            Unchecked.defaultof<aws.Route53RecoveryreadinessResourceSet.Route53RecoveryreadinessResourceSet>
