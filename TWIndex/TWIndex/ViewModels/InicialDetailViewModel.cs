using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using TWIndex.Models;
using Xamarin.Forms;

namespace TWIndex.ViewModels
{
    public class InicialDetailViewModel
    {
            Trabalho _trabalhoSelecionado;

            public Trabalho TrabalhoSelecionado
            {
                get
                {
                    return _trabalhoSelecionado;
                }

                set
                {
                    _trabalhoSelecionado = value;
                    if (value != null)
                        MessagingCenter.Send(TrabalhoSelecionado, "TrabalhoSelecionado");
                }
            }

            public ObservableCollection<Trabalho> TiposTrabalho { get; }

            public InicialDetailViewModel()
            {
                TiposTrabalho = new ObservableCollection<Trabalho>();

                TiposTrabalho.Add(new Trabalho
                {
                    Nome = "Doutorado"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Nome = "Mestrado"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Nome = "Trabalho de Conclusão de Curso"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Nome = "Relatório Técnico"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Nome = "Relatório Científico"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Nome = "Iniciação Tecnológica"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Nome = "Iniciação Científica"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Nome = "Patente"
                });
            }
    }
 }

