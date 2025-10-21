namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticBeanstalkApplicationState<'Name> = { assignments: ResizeArray<aws.ElasticBeanstalkApplication.ElasticBeanstalkApplicationConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application">aws_elastic_beanstalk_application</a>.
    /// </summary>
    type ElasticBeanstalkApplicationBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticBeanstalkApplicationState<Missing> =
            ({ assignments = ResizeArray() } : ElasticBeanstalkApplicationState<Missing>)

        member _.Zero(()) : ElasticBeanstalkApplicationState<Missing> =
            ({ assignments = ResizeArray() } : ElasticBeanstalkApplicationState<Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#name-1">ElasticBeanstalkApplication#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticBeanstalkApplicationState<Missing>, value: string) : ElasticBeanstalkApplicationState<Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticBeanstalkApplicationState<Present>)

        /// <summary>
        /// appversion_lifecycle block. Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#appversion_lifecycle-1">ElasticBeanstalkApplication#appversion_lifecycle</a>
        /// </summary>
        [<CustomOperation "appversion_lifecycle">]
        member _.AppversionLifecycle(state: ElasticBeanstalkApplicationState<'Name>, value: aws.ElasticBeanstalkApplication.ElasticBeanstalkApplicationAppversionLifecycle) : ElasticBeanstalkApplicationState<'Name> =
            state.assignments.Add(fun config -> config.AppversionLifecycle <- value)
            state : ElasticBeanstalkApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#description-1">ElasticBeanstalkApplication#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ElasticBeanstalkApplicationState<'Name>, value: string) : ElasticBeanstalkApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ElasticBeanstalkApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#id-1">ElasticBeanstalkApplication#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticBeanstalkApplicationState<'Name>, value: string) : ElasticBeanstalkApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticBeanstalkApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#tags-1">ElasticBeanstalkApplication#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticBeanstalkApplicationState<'Name>, value: seq<string * string>) : ElasticBeanstalkApplicationState<'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticBeanstalkApplicationState<'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application#tags_all-1">ElasticBeanstalkApplication#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticBeanstalkApplicationState<'Name>, value: seq<string * string>) : ElasticBeanstalkApplicationState<'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticBeanstalkApplicationState<'Name>

        member _.Run(state: ElasticBeanstalkApplicationState<Present>) : aws.ElasticBeanstalkApplication.ElasticBeanstalkApplication =
            let config = aws.ElasticBeanstalkApplication.ElasticBeanstalkApplicationConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticBeanstalkApplication.ElasticBeanstalkApplication(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticBeanstalkApplication: missing required arguments. Must call: name.", 9999, IsError = true)>]
        member _.Run(_: ElasticBeanstalkApplicationState<_>) : aws.ElasticBeanstalkApplication.ElasticBeanstalkApplication =
            Unchecked.defaultof<aws.ElasticBeanstalkApplication.ElasticBeanstalkApplication>
