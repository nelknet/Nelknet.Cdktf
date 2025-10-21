namespace Nelknet.Cdktf.Providers
open System
open System.Collections.Generic
open HashiCorp.Cdktf
open Nelknet.Cdktf
open Nelknet.Cdktf.Internal
type ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name> = { assignments: ResizeArray<aws.ElasticBeanstalkApplicationVersion.ElasticBeanstalkApplicationVersionConfig -> unit> }
    /// <summary>
    /// Represents a <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version">aws_elastic_beanstalk_application_version</a>.
    /// </summary>
    type ElasticBeanstalkApplicationVersionBuilder(logicalId: string) =
        member _.Yield(_: unit) : ElasticBeanstalkApplicationVersionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticBeanstalkApplicationVersionState<Missing, Missing, Missing, Missing>)

        member _.Zero(()) : ElasticBeanstalkApplicationVersionState<Missing, Missing, Missing, Missing> =
            ({ assignments = ResizeArray() } : ElasticBeanstalkApplicationVersionState<Missing, Missing, Missing, Missing>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#application-1">ElasticBeanstalkApplicationVersion#application</a>.
        /// </summary>
        [<CustomOperation "application">]
        member _.Application(state: ElasticBeanstalkApplicationVersionState<Missing, 'Bucket, 'Key, 'Name>, value: string) : ElasticBeanstalkApplicationVersionState<Present, 'Bucket, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.Application <- value)
            ({ assignments = state.assignments } : ElasticBeanstalkApplicationVersionState<Present, 'Bucket, 'Key, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#bucket-1">ElasticBeanstalkApplicationVersion#bucket</a>.
        /// </summary>
        [<CustomOperation "bucket">]
        member _.Bucket(state: ElasticBeanstalkApplicationVersionState<'Application, Missing, 'Key, 'Name>, value: string) : ElasticBeanstalkApplicationVersionState<'Application, Present, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.Bucket <- value)
            ({ assignments = state.assignments } : ElasticBeanstalkApplicationVersionState<'Application, Present, 'Key, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#key-1">ElasticBeanstalkApplicationVersion#key</a>.
        /// </summary>
        [<CustomOperation "key">]
        member _.Key(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, Missing, 'Name>, value: string) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, Present, 'Name> =
            state.assignments.Add(fun config -> config.Key <- value)
            ({ assignments = state.assignments } : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, Present, 'Name>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#name-1">ElasticBeanstalkApplicationVersion#name</a>.
        /// </summary>
        [<CustomOperation "name">]
        member _.Name(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, Missing>, value: string) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, Present> =
            state.assignments.Add(fun config -> config.Name <- value)
            ({ assignments = state.assignments } : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, Present>)

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#description-1">ElasticBeanstalkApplicationVersion#description</a>.
        /// </summary>
        [<CustomOperation "description">]
        member _.Description(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>, value: string) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.Description <- value)
            state : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#force_delete-1">ElasticBeanstalkApplicationVersion#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>, value: bool) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#force_delete-1">ElasticBeanstalkApplicationVersion#force_delete</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "force_delete">]
        member _.ForceDelete(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.ForceDelete <- value)
            state : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#id-1">ElasticBeanstalkApplicationVersion#id</a>. Please be aware that the id field is automatically added to all resources in Terraform providers using a Terraform provider SDK version below 2. If you experience problems setting this value it might not be settable. Please take a look at the provider documentation to ensure it should be settable.
        /// </summary>
        [<CustomOperation "id">]
        member _.Id(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>, value: string) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.Id <- value)
            state : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#process-1">ElasticBeanstalkApplicationVersion#process</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "process">]
        member _.Process(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>, value: bool) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.Process <- value)
            state : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#process-1">ElasticBeanstalkApplicationVersion#process</a>. Accepts: boolean | aws.IResolvable
        /// </summary>
        [<CustomOperation "process">]
        member _.Process(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>, value: HashiCorp.Cdktf.IResolvable) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.Process <- value)
            state : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#tags-1">ElasticBeanstalkApplicationVersion#tags</a>.
        /// </summary>
        [<CustomOperation "tags">]
        member _.Tags(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>, value: seq<string * string>) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.Tags <- dict value)
            state : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>

        /// <summary>
        /// Docs at Terraform Registry: <a href="https://registry.terraform.io/providers/hashicorp/aws/5.100.0/docs/resources/elastic_beanstalk_application_version#tags_all-1">ElasticBeanstalkApplicationVersion#tags_all</a>.
        /// </summary>
        [<CustomOperation "tags_all">]
        member _.TagsAll(state: ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>, value: seq<string * string>) : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name> =
            state.assignments.Add(fun config -> config.TagsAll <- dict value)
            state : ElasticBeanstalkApplicationVersionState<'Application, 'Bucket, 'Key, 'Name>

        member _.Run(state: ElasticBeanstalkApplicationVersionState<Present, Present, Present, Present>) : aws.ElasticBeanstalkApplicationVersion.ElasticBeanstalkApplicationVersion =
            let config = aws.ElasticBeanstalkApplicationVersion.ElasticBeanstalkApplicationVersionConfig()
            for setter in state.assignments do
                setter config
            aws.ElasticBeanstalkApplicationVersion.ElasticBeanstalkApplicationVersion(StackContext.get (), logicalId, config)

        [<CompilerMessage("Aws.elasticBeanstalkApplicationVersion: missing required arguments. Must call: application, bucket, key, name.", 9999, IsError = true)>]
        member _.Run(_: ElasticBeanstalkApplicationVersionState<_, _, _, _>) : aws.ElasticBeanstalkApplicationVersion.ElasticBeanstalkApplicationVersion =
            Unchecked.defaultof<aws.ElasticBeanstalkApplicationVersion.ElasticBeanstalkApplicationVersion>
