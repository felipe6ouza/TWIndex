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
                    Tipo = "Doutorado"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Tipo = "Mestrado"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Tipo = "Trabalho de Conclusão de Curso"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Tipo = "Relatório Técnico"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Tipo = "Relatório Científico"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Tipo = "Iniciação Tecnológica"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Tipo = "Iniciação Científica"
                });

                TiposTrabalho.Add(new Trabalho
                {
                    Tipo = "Patente"
                });
            }
    }
 }

