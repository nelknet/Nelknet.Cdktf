namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type CloudfrontKeyGroupState<'Items, 'Name> = { assignments: ResizeArray<aws.CloudfrontKeyGroup.CloudfrontKeyGroupConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_key_group">aws_cloudfront_key_group</a>.
    /// </summary>
    type CloudfrontKeyGroupBuilder(logicalId: string) =
        member _.Yield(_: unit) : CloudfrontKeyGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontKeyGroupState<Missing, Missing>)

        member _.Zero(()) : CloudfrontKeyGroupState<Missing, Missing> =
            ({ assignments = ResizeArray() } : CloudfrontKeyGroupState<Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_key_group#items-1">CloudfrontKeyGroup#items</a>.
        /// </summary>
        [<CustomOperation "items">]
        member _.Items(state: CloudfrontKeyGroupState<Missing, 'Name>, value: seq<string>) : CloudfrontKeyGroupState<Present, 'Name> =
            state.assignments.Add(fun config -> config.Items <- (value |> Seq.toArray))
            ({ assignments = state.assignments } : CloudfrontKeyGroupState<Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_key_group#name-1">CloudfrontKeyGroup#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: CloudfrontKeyGroupState<'Items, Missing>, value: string) : CloudfrontKeyGroupState<'Items, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : CloudfrontKeyGroupState<'Items, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_key_group#comment-1">CloudfrontKeyGroup#comment</a>.
        /// </summary>
        [<CustomOperation "comment">]
        member _.Comment(state: CloudfrontKeyGroupState<'Items, 'Name>, value: string) : CloudfrontKeyGroupState<'Items, 'Name> =
            state.assignments.Add(fun config -> config.Comment <- value)
            state : CloudfrontKeyGroupState<'Items, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/cloudfront_key_group#id-1">CloudfrontKeyGroup#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: CloudfrontKeyGroupState<'Items, 'Name>, value: string) : CloudfrontKeyGroupState<'Items, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : CloudfrontKeyGroupState<'Items, 'Name>

        member _.Run(state: CloudfrontKeyGroupState<Present, Present>) : aws.CloudfrontKeyGroup.CloudfrontKeyGroup =
            let config = aws.CloudfrontKeyGroup.CloudfrontKeyGroupConfig()
            for setter in state.assignments do
                setter config
            aws.CloudfrontKeyGroup.CloudfrontKeyGroup(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.cloudfrontKeyGroup: missing required arguments. Must call: items, name.", 9999, IsError = true)>]
        member _.Run(_: CloudfrontKeyGroupState<_, _>) : aws.CloudfrontKeyGroup.CloudfrontKeyGroup =
            Unchecked.defaultof<aws.CloudfrontKeyGroup.CloudfrontKeyGroup>
